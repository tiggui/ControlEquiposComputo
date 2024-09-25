using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEquiposComputo.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoID { get; set; }

        [Required(ErrorMessage = "El laboratorio es requerido")]
        [ForeignKey("Laboratorio")]
        public int LaboratorioID { get; set; }

        [Required(ErrorMessage = "El número de equipo es requerido")]
        [StringLength(45, ErrorMessage = "El número de equipo no puede exceder 45 caracteres")]
        public string NumeroEquipo { get; set; }

        [Required(ErrorMessage = "La marca es requerida")]
        [StringLength(45, ErrorMessage = "La marca no puede exceder 45 caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El modelo es requerido")]
        [StringLength(45, ErrorMessage = "El modelo no puede exceder 45 caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [StringLength(45, ErrorMessage = "El estado no puede exceder 45 caracteres")]
        public string Estado { get; set; }

        // Navigation property
        public Laboratorio Laboratorio { get; set; }
        public ICollection<UsoEquipo> UsoEquipos { get; set; }
    }
}
