using System.ComponentModel.DataAnnotations;

namespace StreamWebPage.Services.models

{
    public class EmailModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Message { get; set; }
    }
}