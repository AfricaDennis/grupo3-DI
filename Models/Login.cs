using System.ComponentModel.DataAnnotations;

namespace grupo3.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email requerido.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contraseña requerida.")]
        public string Password { get; set; }
    }
}
