using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlEquiposComputo.Models
{
    public class UsoEquipo
    {
        [Key]
        public int UsoEquipoID { get; set; }

        [Required(ErrorMessage = "El estudiante es requerido")]
        [ForeignKey("Estudiante")]
        public int EstudianteID { get; set; }

        [Required(ErrorMessage = "El equipo es requerido")]
        [ForeignKey("Equipo")]
        public int EquipoID { get; set; }

        [Required(ErrorMessage = "La clase es requerida")]
        [ForeignKey("Clase")]
        public int ClaseID { get; set; }

        [Required(ErrorMessage = "La fecha de asignación es requerida")]
        public DateTime FechaAsignacion { get; set; }

        [Required(ErrorMessage = "La actividad es requerida")]
        [StringLength(45, ErrorMessage = "La actividad no puede exceder 45 caracteres")]
        public string Actividad { get; set; }

        // Navigation properties
        public Estudiante Estudiante { get; set; }
        public Equipo Equipo { get; set; }
        public Clase Clase { get; set; }
    }
}
