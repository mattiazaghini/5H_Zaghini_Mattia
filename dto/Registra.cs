using System.ComponentModel.DataAnnotations;

namespace _5H_Zaghini_Mattia.dto
{
    public class RegistraDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
         
        [DataType(DataType.Password)]
        [Display(Name ="Conferma Password")]
        [Compare("Password",ErrorMessage ="Le password non corrispondono")]
        public string ConfirmPassword { get; set; }
    }
}