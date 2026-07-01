using Microsoft.Data.Sqlite;

namespace CP_Ideas_Tracker
{
    public static class ProblemRepository
    {
        public static void AddProblem(ProblemNote problem)
        {
            using var connection = new SqliteConnection(Database.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                INSERT INTO Problems
                (
                    UserId,
                    ProblemLink,
                    ProblemName,
                    Platform,
                    Idea,
                    Tags,
                    SourceUser,
                    IsImported,
                    CreatedAt,
                    UpdatedAt
                )
                VALUES
                (
                    @userId,
                    @problemLink,
                    @problemName,
                    @platform,
                    @idea,
                    @tags,
                    @sourceUser,
                    @isImported,
                    @createdAt,
                    @updatedAt
                );
            ";

            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            command.Parameters.AddWithValue("@userId", problem.UserId);
            command.Parameters.AddWithValue("@problemLink", problem.ProblemLink);
            command.Parameters.AddWithValue("@problemName", problem.ProblemName);
            command.Parameters.AddWithValue("@platform", problem.Platform);
            command.Parameters.AddWithValue("@idea", problem.Idea);
            command.Parameters.AddWithValue("@tags", problem.Tags);
            command.Parameters.AddWithValue("@sourceUser", problem.SourceUser);
            command.Parameters.AddWithValue("@isImported", problem.IsImported ? 1 : 0);
            command.Parameters.AddWithValue("@createdAt", now);
            command.Parameters.AddWithValue("@updatedAt", now);

            command.ExecuteNonQuery();
        }

        public static List<ProblemNote> GetProblemsByUser(int userId)
        {
            List<ProblemNote> problems = new List<ProblemNote>();

            using var connection = new SqliteConnection(Database.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                SELECT
                    Id,
                    UserId,
                    ProblemLink,
                    ProblemName,
                    Platform,
                    Idea,
                    Tags,
                    SourceUser,
                    IsImported,
                    CreatedAt,
                    UpdatedAt
                FROM Problems
                WHERE UserId = @userId
                ORDER BY Id DESC;
            ";

            command.Parameters.AddWithValue("@userId", userId);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ProblemNote problem = new ProblemNote();

                problem.Id = reader.GetInt32(0);
                problem.UserId = reader.GetInt32(1);
                problem.ProblemLink = reader.GetString(2);
                problem.ProblemName = reader.IsDBNull(3) ? "" : reader.GetString(3);
                problem.Platform = reader.IsDBNull(4) ? "" : reader.GetString(4);
                problem.Idea = reader.GetString(5);
                problem.Tags = reader.IsDBNull(6) ? "" : reader.GetString(6);
                problem.SourceUser = reader.IsDBNull(7) ? "" : reader.GetString(7);
                problem.IsImported = reader.GetInt32(8) == 1;
                problem.CreatedAt = reader.IsDBNull(9) ? "" : reader.GetString(9);
                problem.UpdatedAt = reader.IsDBNull(10) ? "" : reader.GetString(10);

                problems.Add(problem);
            }

            return problems;
        }

        public static void DeleteProblem(int problemId, int userId)
        {
            using var connection = new SqliteConnection(Database.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
                                   DELETE FROM Problems
                                   WHERE Id = @problemId AND UserId = @userId;
                                   ";

            command.Parameters.AddWithValue("@problemId", problemId);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }
        public static void UpdateProblem(ProblemNote problem)
        {
            using var connection = new SqliteConnection(Database.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = @"
        UPDATE Problems
        SET
            ProblemLink = @problemLink,
            ProblemName = @problemName,
            Platform = @platform,
            Idea = @idea,
            Tags = @tags,
            UpdatedAt = @updatedAt
        WHERE Id = @id AND UserId = @userId;
    ";

            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            command.Parameters.AddWithValue("@problemLink", problem.ProblemLink);
            command.Parameters.AddWithValue("@problemName", problem.ProblemName);
            command.Parameters.AddWithValue("@platform", problem.Platform);
            command.Parameters.AddWithValue("@idea", problem.Idea);
            command.Parameters.AddWithValue("@tags", problem.Tags);
            command.Parameters.AddWithValue("@updatedAt", now);
            command.Parameters.AddWithValue("@id", problem.Id);
            command.Parameters.AddWithValue("@userId", problem.UserId);

            command.ExecuteNonQuery();
        }
    }
}   