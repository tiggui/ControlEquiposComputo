using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Incidente
    {
        [Key]
        public int IncidenteID { get; set; }

        [ForeignKey("Laboratorio")]
        public int LaboratorioID { get; set; }

        [ForeignKey("Equipo")]
        public int? EquipoID { get; set; }  // Incidente puede ser relacionado con equipo o con el laboratorio en general

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

        [ForeignKey("Tecnico")]
        public int TecnicoID { get; set; }

        [Required]
        public DateTime FechaIncidente { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public string Estado { get; set; }  // Pendiente, En proceso, Resuelto

        

        public virtual Laboratorio Laboratorio { get; set; }
        public virtual Equipo Equipo { get; set; }
        public virtual Tecnico Tecnico { get; set; }
        public virtual Usuario  Usuario { get; set; }
    }
}
