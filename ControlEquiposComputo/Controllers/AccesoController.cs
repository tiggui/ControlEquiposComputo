using Microsoft.AspNetCore.Mvc;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.ViewModels;

using ControlEquiposComputo.Data;
using Microsoft.EntityFrameworkCore;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;



namespace ControlEquiposComputo.Controllers
{
    public class AccesoController : Controller
    {
        private readonly AppDbContext _context;

        public AccesoController(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(DocenteVM modelo)
        {
            if (modelo.Contraseña != modelo.ConfirmarContraseña )
            {

                ViewData["Mensaje"] = "Las contraseña no coinciden";
                return View();
            }

            if (modelo.Contraseña.Length < 8)
            {

                ViewData["Mensaje"] = "La contraseña tiene que ser al menos de 8 Caracteres";
                return View();
            }

            Docente docente = new Docente()
            {
                Nombre = modelo.Nombre,
                Apellido = modelo.Apellido,
                Email = modelo.Email,
                Contraseña = modelo.Contraseña,
                Curso = modelo.Curso,
            };

            await _context.Docentes.AddAsync(docente);
            await _context.SaveChangesAsync();

            if (docente.DocenteID != 0)
            {
                return RedirectToAction("Login", "Acceso");
            }
            ViewData["Mensaje"] = "No se pudo crear el usuario";
            return View();
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM modelo)
        {
            Docente? docente_encontradi = await _context.Docentes
                            .Where(u => 
                                u.Email == modelo.Email &&
                                u.Contraseña==modelo.Contraseña
                            ).FirstOrDefaultAsync();
            if (docente_encontradi == null)
            {
                ViewData["Mensaje"] = "No se encontraron coincidencias";
                return View();
            }

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, docente_encontradi.Nombre)
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            AuthenticationProperties properties = new AuthenticationProperties()
            {
                AllowRefresh = true,
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                properties
                );

            return RedirectToAction("Index", "Home");


        }

    }
}
