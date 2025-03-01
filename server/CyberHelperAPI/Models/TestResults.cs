namespace server.Models
{
    public class TestResult
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
    }

}
