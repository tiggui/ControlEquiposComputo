using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEquiposComputo.Models
{
    public class Mantenimiento
    {
        [Key]
        public int MantenimientoID { get; set; }

        [Required(ErrorMessage = "El técnico es requerido")]
        [ForeignKey("Tecnico")]
        public int TecnicoID { get; set; }

        [Required(ErrorMessage = "El equipo es requerido")]
        [ForeignKey("Equipo")]
        public int EquipoID { get; set; }

        [Required(ErrorMessage = "La fecha de mantenimiento es requerida")]
        public DateTime FechaMantenimiento { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(45, ErrorMessage = "La descripción no puede exceder 45 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [StringLength(45, ErrorMessage = "El estado no puede exceder 45 caracteres")]
        public string Estado { get; set; }

        // Navigation properties
        public Tecnico Tecnico { get; set; }
        public Equipo Equipo { get; set; }
    }
}
