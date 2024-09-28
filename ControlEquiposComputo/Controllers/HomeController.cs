using ControlEquiposComputo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;


[Authorize]
public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Obtener la lista de clases para mostrar en el Home
        var clases = _context.Clases.ToList();
        return View(clases);  // Enviar la lista de clases al Index de Home


    }

    // Acción que devuelve el parcial con la lista de UsoEquipos filtrados por ClaseID
    public IActionResult GetUsoEquiposPorClase(int claseId)
    {
        var usoEquipos = _context.UsoEquipos
                                  .Where(u => u.ClaseID == claseId)
                                  .Include(u => u.Estudiante)
                                  .Include(u => u.Equipo)
                                  .ToList();

      

        return PartialView("_UsoEquiposPartial", usoEquipos);  // Retorna la vista parcial
    }

    public async Task <IActionResult> Salir()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);   
        return RedirectToAction("Login","Acceso");
    }

    
}
