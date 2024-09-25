using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Docente
    {
        [Key]
        public int DocenteID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder 45 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(45, ErrorMessage = "El apellido no puede exceder 45 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El curso es requerido")]
        [StringLength(45, ErrorMessage = "El curso no puede exceder 45 caracteres")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        [StringLength(45, ErrorMessage = "El email no puede exceder 45 caracteres")]
        public string Email { get; set; }


    }
}
