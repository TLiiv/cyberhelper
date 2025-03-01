using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsPhishing { get; set; }
        public string? HiddenLink { get; set; }
        public int Difficulty { get; set; }
    }
}
    

