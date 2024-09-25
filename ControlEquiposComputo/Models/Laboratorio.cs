using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Laboratorio
    {
        [Key]
        public int LaboratorioID { get; set; }

        [Required(ErrorMessage = "El nombre del laboratorio es requerido")]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder 45 caracteres")]
        public string NombreLaboratorio { get; set; }

        [Required(ErrorMessage = "La ubicación es requerida")]
        [StringLength(45, ErrorMessage = "La ubicación no puede exceder 45 caracteres")]
        public string Ubicacion { get; set; }

        [Required(ErrorMessage = "La capacidad es requerida")]        
        public int Capacidad { get; set; }
    }
}
