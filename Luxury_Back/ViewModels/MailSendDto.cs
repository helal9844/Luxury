using System.ComponentModel.DataAnnotations;

namespace Luxury_Back.ViewModels
{
    public class MailSendDto
    {
        [Required]
        public string? ToEmail { get; set; } 
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? Body { get; set; }
        public IList<FormFile>? Attachments { get; set; }

    }
}
