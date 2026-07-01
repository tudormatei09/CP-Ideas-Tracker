namespace CP_Ideas_Tracker
{
    public class ProblemNote
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string ProblemLink { get; set; } = "";

        public string ProblemName { get; set; } = "";

        public string Platform { get; set; } = "";

        public string Idea { get; set; } = "";

        public string Tags { get; set; } = "";

        public string SourceUser { get; set; } = "";

        public bool IsImported { get; set; }

        public string CreatedAt { get; set; } = "";

        public string UpdatedAt { get; set; } = "";
    }
}