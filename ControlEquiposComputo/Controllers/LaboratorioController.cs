using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;

namespace ControlEquiposComputo.Controllers
{
    public class LaboratorioController : Controller
    {
        private readonly AppDbContext _context;

        public LaboratorioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Laboratorio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Laboratorios.ToListAsync());
        }

        // GET: Laboratorio/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratorio = await _context.Laboratorios
                .FirstOrDefaultAsync(m => m.LaboratorioID == id);
            if (laboratorio == null)
            {
                return NotFound();
            }

            return View(laboratorio);
        }

        // GET: Laboratorio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Laboratorio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaboratorioID,NombreLaboratorio,Ubicacion,Capacidad,Responsable")] Laboratorio laboratorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratorio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laboratorio);
        }

        // GET: Laboratorio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratorio = await _context.Laboratorios.FindAsync(id);
            if (laboratorio == null)
            {
                return NotFound();
            }
            return View(laboratorio);
        }

        // POST: Laboratorio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaboratorioID,NombreLaboratorio,Ubicacion,Capacidad,Responsable")] Laboratorio laboratorio)
        {
            if (id != laboratorio.LaboratorioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laboratorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaboratorioExists(laboratorio.LaboratorioID))
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
            return View(laboratorio);
        }

        // GET: Laboratorio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratorio = await _context.Laboratorios
                .FirstOrDefaultAsync(m => m.LaboratorioID == id);
            if (laboratorio == null)
            {
                return NotFound();
            }

            return View(laboratorio);
        }

        // POST: Laboratorio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laboratorio = await _context.Laboratorios.FindAsync(id);
            _context.Laboratorios.Remove(laboratorio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratorioExists(int id)
        {
            return _context.Laboratorios.Any(e => e.LaboratorioID == id);
        }
    }
}
