using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Laboratorio
    {
        [Key]
        public int LaboratorioID { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreLaboratorio { get; set; }

        public string Ubicacion { get; set; }

        public int Capacidad { get; set; }

        public string Responsable { get; set; }

        // Relación con equipos
        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
