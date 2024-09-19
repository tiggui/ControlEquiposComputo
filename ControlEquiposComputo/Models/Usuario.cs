using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string TipoUsuario { get; set; }
    }
}
