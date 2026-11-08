using System.ComponentModel.DataAnnotations;

namespace cibertec_demo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es oblligatorio")] //para campo obligatorio
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 carecteres")] //longitud maxima
        [Display(Name = "Nombre completo")] // nombre a mostrar en el formulario
        public string nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [StringLength(50, ErrorMessage = "El correo no puede superar los 50 carecteres")]
        [EmailAddress(ErrorMessage = "Correo electronico invalido")]
        [Display(Name = "Correo electronico")]
        public string correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatorio")]
        [StringLength(50,MinimumLength = 4, ErrorMessage = "La contraseña debe tener entre 4 y 50 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Constraseña")]
        public string clave { get; set; }
        [Display(Name = "Fecha de registro")]

        public DateTime fechaRegistro { get; set; }
    }
}
