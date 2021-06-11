using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.dto
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Ricordami")]
        public bool RememberMe { get; set; }
    }
}
