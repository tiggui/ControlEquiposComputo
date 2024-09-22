using Microsoft.AspNetCore.Mvc;
using ControlEquiposComputo.Data;
using ControlEquiposComputo.Models;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Registrarse()
        {
            return View();
        }
    }
}
