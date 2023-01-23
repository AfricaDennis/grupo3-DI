using System.ComponentModel.DataAnnotations;

namespace grupo3.Models
{
    public class User
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Nombre requerido.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Apellidos requerido.")]
        public string surname { get; set; }
        [Required(ErrorMessage = "Contraseña requerida.")]
        public string password { get; set; }
        [Required(ErrorMessage = "Confirmación requerida.")]
        [Compare("password", ErrorMessage = "Las contraseñas deben coincidir")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email requerido.")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Telefono requerido.")]
        [Phone]
        public string phone { get; set; }
        public bool student { get; set; }
        public bool teacher { get; set; }
        public bool admin { get; set; }

    }
}
