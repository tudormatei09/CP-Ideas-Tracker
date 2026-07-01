using Microsoft.Data.Sqlite;

namespace CP_Ideas_Tracker
{
    public static class Database
    {
        public static string DataFolder =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

        public static string DbPath =>
            Path.Combine(DataFolder, "app.db");

        public static string ConnectionString =>
            $"Data Source={DbPath}";

        public static string SchemaPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schema.sql");

        public static void Initialize()
        {
            Directory.CreateDirectory(DataFolder);

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            string sql = File.ReadAllText(SchemaPath);

            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}