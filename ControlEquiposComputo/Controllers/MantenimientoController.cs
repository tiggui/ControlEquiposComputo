using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlEquiposComputo.Controllers
{
    public class MantenimientoController : Controller
    {
        private readonly AppDbContext _context;

        public MantenimientoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Mantenimiento
        public async Task<IActionResult> Index()
        {
            var mantenimientos = _context.Mantenimientos
                .Include(m => m.Equipo)
                .Include(m => m.Tecnico);
            return View(await mantenimientos.ToListAsync());
        }

        // GET: Mantenimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mantenimiento = await _context.Mantenimientos
                .Include(m => m.Equipo)
                .Include(m => m.Tecnico)
                .FirstOrDefaultAsync(m => m.MantenimientoID == id);
            if (mantenimiento == null)
            {
                return NotFound();
            }

            return View(mantenimiento);
        }

        // GET: Mantenimiento/Create
        public async Task<IActionResult> Create()
        {
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca");
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre");
            return View();
        }

        // POST: Mantenimiento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MantenimientoID,EquipoID,FechaMantenimiento,Descripcion,TecnicoID")] Mantenimiento mantenimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mantenimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca", mantenimiento.EquipoID);
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre", mantenimiento.TecnicoID);
            return View(mantenimiento);
        }

        // GET: Mantenimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mantenimiento = await _context.Mantenimientos.FindAsync(id);
            if (mantenimiento == null)
            {
                return NotFound();
            }

            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca", mantenimiento.EquipoID);
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre", mantenimiento.TecnicoID);
            return View(mantenimiento);
        }

        // POST: Mantenimiento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MantenimientoID,EquipoID,FechaMantenimiento,Descripcion,TecnicoID")] Mantenimiento mantenimiento)
        {
            if (id != mantenimiento.MantenimientoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mantenimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MantenimientoExists(mantenimiento.MantenimientoID))
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
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca", mantenimiento.EquipoID);
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre", mantenimiento.TecnicoID);
            return View(mantenimiento);
        }

        // GET: Mantenimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mantenimiento = await _context.Mantenimientos
                .Include(m => m.Equipo)
                .Include(m => m.Tecnico)
                .FirstOrDefaultAsync(m => m.MantenimientoID == id);
            if (mantenimiento == null)
            {
                return NotFound();
            }

            return View(mantenimiento);
        }

        // POST: Mantenimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mantenimiento = await _context.Mantenimientos.FindAsync(id);
            if (mantenimiento != null)
            {
                _context.Mantenimientos.Remove(mantenimiento);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool MantenimientoExists(int id)
        {
            return _context.Mantenimientos.Any(m => m.MantenimientoID == id);
        }
    }
}
