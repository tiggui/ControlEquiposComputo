using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Incidente
    {
        [Key]
        public int IncidenteID { get; set; }

        [Required(ErrorMessage = "El uso de equipo es requerido")]
        [ForeignKey("UsoEquipo")]
        public int UsoEquipoID { get; set; }

        [Required(ErrorMessage = "La fecha del incidente es requerida")]
        public DateTime FechaIncidente { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(45, ErrorMessage = "La descripción no puede exceder 45 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [StringLength(45, ErrorMessage = "El estado no puede exceder 45 caracteres")]
        public string Estado { get; set; }

        // Navigation property
        public UsoEquipo UsoEquipo { get; set; }

    }
}
