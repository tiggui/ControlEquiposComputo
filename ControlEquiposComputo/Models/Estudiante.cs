using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder 45 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(45, ErrorMessage = "El apellido no puede exceder 45 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        [StringLength(45, ErrorMessage = "El correo no puede exceder 45 caracteres")]
        public string Email { get; set; }
    }
}
