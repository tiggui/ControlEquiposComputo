using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaID { get; set; }

        [Required]
        public int UsuarioID { get; set; }

        [Required]
        public int LaboratorioID { get; set; }

        public DateTime FechaReserva { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        // Relaciones
        public virtual Usuario Usuario { get; set; }
        public virtual Laboratorio Laboratorio { get; set; }
    }
}
