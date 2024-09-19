using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoID { get; set; }

        [Required]
        public int SalaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string TipoEquipo { get; set; }

        public string NumeroSerie { get; set; }

        public string Estado { get; set; }

        // Relación con Laboratorio
        public virtual Laboratorio Labaratorio { get; set; }
    }
}
