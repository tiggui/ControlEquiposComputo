using System.ComponentModel.DataAnnotations;

namespace ControlEquiposComputo.ViewModels
{
    public class DocenteVM
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContraseña { get; set; }
        public string Email { get; set; }
    }
}
