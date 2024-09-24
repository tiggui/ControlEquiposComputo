using ControlEquiposComputo.Data;
using ControlEquiposComputo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ControlEquiposComputo.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext db;

        public HomeController(AppDbContext context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            
            var laboratorios = db.Laboratorios.ToList();
            var equipos = db.Equipos.ToList();
            var mantenimientosPendientes = db.Mantenimientos.Where(m => m.Descripcion != "Pendiente").ToList();
            var reservasHoy = db.Reservas.Where(r => r.FechaReserva == System.DateTime.Today).ToList();
            var usoHoy = db.Reservas.Where(u => u.FechaReserva == System.DateTime.Today).ToList();

            
            ViewBag.Laboratorios = laboratorios;
            ViewBag.Equipos = equipos;
            ViewBag.MantenimientosPendientes = mantenimientosPendientes;
            ViewBag.ReservasHoy = reservasHoy;
            ViewBag.UsoHoy = usoHoy;

            return View();
            //private readonly ILogger<HomeController> _logger;

            //public HomeController(ILogger<HomeController> logger)
            //{
            //    _logger = logger;
            //}

            //public IActionResult Index()
            //{
            //    return View();
            //}

            //public IActionResult Privacy()
            //{
            //    return View();
            //}

            //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            //public IActionResult Error()
            //{
            //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            //}
        }
    }
}
