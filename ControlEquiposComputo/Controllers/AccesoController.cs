using Microsoft.AspNetCore.Mvc;
using ControlEquiposComputo.Models; // Asegúrate de que este espacio de nombres sea correcto

namespace ControlEquiposComputo.Controllers
{
    public class AccesoController : Controller
    {
        // Método para mostrar la vista de registro
        [HttpGet]
        public IActionResult Registrar()
        {
            return View(); // Este método debe devolver la vista
        }

        // Método para manejar el registro (POST)
        [HttpPost]
        public IActionResult Registrar(RegistroModel model)
        {
            if (ModelState.IsValid)
            {
                switch (model.UserType)
                {
                    case "Docente":
                        // Lógica para registrar como docente
                        // Ejemplo: 
                        var nuevoDocente = new Docente
                        {
                            Email = model.Email,
                            // Otros campos necesarios
                        };
                        // Guardar en la base de datos
                        break;

                    case "Estudiante":
                        // Lógica para registrar como estudiante
                        break;

                    case "Tecnico":
                        // Lógica para registrar como técnico
                        break;

                    default:
                        ModelState.AddModelError("", "Seleccione un tipo de usuario.");
                        break;
                }

                // Redirigir después del registro exitoso
                return RedirectToAction("Index", "Home");
            }

            return View(model); // Regresar al formulario si hay errores
        }

    }
}
