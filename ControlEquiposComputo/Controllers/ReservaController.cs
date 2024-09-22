using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlEquiposComputo.Controllers
{
    public class ReservaController : Controller
    {
        private readonly AppDbContext _context;

        public ReservaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reserva
        public async Task<IActionResult> Index()
        {
            var reservas = _context.Reservas.Include(r => r.Usuario).Include(r => r.Laboratorio);
            return View(await reservas.ToListAsync());
        }

        // GET: Reserva/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .Include(r => r.Usuario)
                .Include(r => r.Laboratorio)
                .FirstOrDefaultAsync(m => m.ReservaID == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reserva/Create
        public IActionResult Create()
        {
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre");
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio");
            return View();
        }

        // POST: Reserva/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservaID,UsuarioID,LaboratorioID,FechaReserva,HoraInicio,HoraFin")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre", reserva.UsuarioID);
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", reserva.LaboratorioID);
            return View(reserva);
        }

        // GET: Reserva/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre", reserva.UsuarioID);
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", reserva.LaboratorioID);
            return View(reserva);
        }

        // POST: Reserva/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservaID,UsuarioID,LaboratorioID,FechaReserva,HoraInicio,HoraFin")] Reserva reserva)
        {
            if (id != reserva.ReservaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.ReservaID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre", reserva.UsuarioID);
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", reserva.LaboratorioID);
            return View(reserva);
        }

        // GET: Reserva/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .Include(r => r.Usuario)
                .Include(r => r.Laboratorio)
                .FirstOrDefaultAsync(m => m.ReservaID == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reserva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reservas.Any(r => r.ReservaID == id);
        }
    }
}
