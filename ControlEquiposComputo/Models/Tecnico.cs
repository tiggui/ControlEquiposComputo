using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Tecnico
    {
        [Key]
        public int TecnicoID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [StringLength(50)]
        public string Especialidad { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}