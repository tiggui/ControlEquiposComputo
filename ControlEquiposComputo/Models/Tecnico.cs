using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Tecnico
    {
        [Key]
        public int TecnicoID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder 45 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(45, ErrorMessage = "El apellido no puede exceder 45 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La especialidad es requerida")]
        [StringLength(45, ErrorMessage = "La especialidad no puede exceder 45 caracteres")]
        public string Especialidad { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [Phone(ErrorMessage = "Formato de teléfono no válido")]
        [StringLength(45, ErrorMessage = "El teléfono no puede exceder 45 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        [StringLength(45, ErrorMessage = "El email no puede exceder 45 caracteres")]
        public string Email { get; set; }
    }
}