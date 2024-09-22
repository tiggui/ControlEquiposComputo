using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlEquiposComputo.Controllers
{
    public class EquipoController : Controller
    {
        private readonly AppDbContext _context;

        public EquipoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Equipo
        public async Task<IActionResult> Index()
        {
            var equipos = _context.Equipos.Include(e => e.Laboratorio);
            return View(await equipos.ToListAsync());
        }

        // GET: Equipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipos
                .Include(e => e.Laboratorio)
                .FirstOrDefaultAsync(m => m.EquipoID == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // GET: Equipo/Create
        public IActionResult Create()
        {
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio");
            return View();
        }

        // POST: Equipo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipoID,LaboratorioID,Marca,Modelo,TipoEquipo,NumeroSerie,Estado")] Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", equipo.LaboratorioID);
            return View(equipo);
        }

        // GET: Equipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipos.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", equipo.LaboratorioID);
            return View(equipo);
        }

        // POST: Equipo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipoID,LaboratorioID,Marca,Modelo,TipoEquipo,NumeroSerie,Estado")] Equipo equipo)
        {
            if (id != equipo.EquipoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipoExists(equipo.EquipoID))
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
            ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", equipo.LaboratorioID);
            return View(equipo);
        }

        // GET: Equipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipos
                .Include(e => e.Laboratorio)
                .FirstOrDefaultAsync(m => m.EquipoID == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // POST: Equipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipo = await _context.Equipos.FindAsync(id);
            if (equipo != null)
            {
                _context.Equipos.Remove(equipo);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipos.Any(e => e.EquipoID == id);
        }
    }
}
