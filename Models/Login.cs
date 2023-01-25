using System.ComponentModel.DataAnnotations;

namespace grupo3.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email requerido.")]
        [EmailAddress(ErrorMessage = "No es una dirección de correo electrónico válida.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Contraseña requerida.")]
        public string password { get; set; }
    }
}
