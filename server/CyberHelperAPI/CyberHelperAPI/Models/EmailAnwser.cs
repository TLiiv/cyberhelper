namespace CyberHelperAPI.Models
{
    public class EmailAnswer
    {
        public Guid Id { get; set; }
        public Guid TestResultId { get; set; }
        public Guid EmailId { get; set; }
        public bool UserAnswer { get; set; } //true = marked as phishing
        public bool IsCorrect { get; set; } //is it phising
    }
}
