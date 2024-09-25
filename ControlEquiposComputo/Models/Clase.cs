using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEquiposComputo.Models
{
    public class Clase
    {
        [Key]
        public int ClaseID { get; set; }

        [Required(ErrorMessage = "El docente es requerido")]
        [ForeignKey("Docente")]
        public int DocenteID { get; set; }

        [Required(ErrorMessage = "El laboratorio es requerido")]
        [ForeignKey("Laboratorio")]
        public int LaboratorioID { get; set; }

        [Required(ErrorMessage = "El nombre de la clase es requerido")]
        [StringLength(45, ErrorMessage = "El nombre de la clase no puede exceder 45 caracteres")]
        public string NombreClase { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        public DateTime Inicio { get; set; }

        [Required(ErrorMessage = "La fecha de finalización es requerida")]
        public DateTime Fin { get; set; }

        // Navigation properties
        public Docente Docente { get; set; }
        public Laboratorio Laboratorio { get; set; }
    }
}
