using Microsoft.Data.Sqlite;

namespace CP_Ideas_Tracker
{
    public static class UserRepository
    {
        public static bool RegisterUser(string username, string password, out string errorMessage)
        {
            errorMessage = "";

            username = username.Trim();

            if (username == "" || password == "")
            {
                errorMessage = "Username and password are required.";
                return false;
            }

            string passwordHash = PasswordHelper.HashPassword(password);

            using var connection = new SqliteConnection(Database.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Users (Username, PasswordHash)
                VALUES (@username, @passwordHash);
            ";

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwordHash", passwordHash);

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqliteException)
            {
                errorMessage = "Username already exists.";
                return false;
            }
        }

        public static int? LoginUser(string username, string password)
        {
            username = username.Trim();

            using var connection = new SqliteConnection(Database.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT Id, PasswordHash
                FROM Users
                WHERE Username = @username;
            ";

            command.Parameters.AddWithValue("@username", username);

            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            int userId = reader.GetInt32(0);
            string savedHash = reader.GetString(1);

            bool passwordIsCorrect = PasswordHelper.VerifyPassword(password, savedHash);

            if (!passwordIsCorrect)
            {
                return null;
            }

            return userId;
        }
    }
}