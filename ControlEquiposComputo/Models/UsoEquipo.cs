namespace ControlEquiposComputo.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UsoEquipo
{
    [Key]
    public int UsoEquipoID { get; set; }

    [ForeignKey("Equipo")]
    public int EquipoID { get; set; }

    [ForeignKey("Usuario")]
    public int UsuarioID { get; set; }  // Quién está utilizando el equipo

    [Required]
    public DateTime FechaUso { get; set; }

    [Required]
    public TimeSpan HoraInicio { get; set; }

    [Required]
    public TimeSpan HoraFin { get; set; }

    [Required]
    [StringLength(200)]
    public string Actividad { get; set; }  // Ej. Clase, Taller, Investigación, Mantenimiento

    public virtual Equipo Equipo { get; set; }
    public virtual Usuario Usuario { get; set; }
}

