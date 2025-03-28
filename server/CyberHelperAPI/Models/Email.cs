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
        public string? DisplayLink { get; set; }
        public string? HiddenLink { get; set; }
        public int Difficulty { get; set; }
        public string? Footer { get; set; }
        public string? ContactNumber { get; set; }
        public string? Signature { get; set; }
        public string? ImgUrl { get; set; }
    }
}
    

