using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Mantenimiento
    {
        [Key]
        public int MantenimientoID { get; set; }

        [Required]
        public int EquipoID { get; set; }

        public DateTime FechaMantenimiento { get; set; }

        public string Descripcion { get; set; }

        public int TecnicoID { get; set; }

        // Relación con equipo
        public virtual Equipo Equipo { get; set; }
        public virtual Tecnico Tecnico { get; set; }
    }
}
