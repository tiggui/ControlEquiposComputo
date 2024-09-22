using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;

namespace ControlEquiposComputo.Controllers
{
    public class TecnicoController : Controller
    {
        private readonly AppDbContext _context;

        public TecnicoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Tecnico
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tecnicos.ToListAsync());
        }

        // GET: Tecnico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.FindAsync(id);
            if (tecnico == null)
            {
                return NotFound();
            }

            return View(tecnico);
        }

        // GET: Tecnico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tecnico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TecnicoID,Nombre,Apellido,Especialidad,Telefono,Email")] Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tecnico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tecnico);
        }

        // GET: Tecnico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.FindAsync(id);
            if (tecnico == null)
            {
                return NotFound();
            }
            return View(tecnico);
        }

        // POST: Tecnico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TecnicoID,Nombre,Apellido,Especialidad,Telefono,Email")] Tecnico tecnico)
        {
            if (id != tecnico.TecnicoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tecnico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TecnicoExists(tecnico.TecnicoID))
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
            return View(tecnico);
        }

        // GET: Tecnico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.FindAsync(id);
            if (tecnico == null)
            {
                return NotFound();
            }

            return View(tecnico);
        }

        // POST: Tecnico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tecnico = await _context.Tecnicos.FindAsync(id);
            if (tecnico != null)
            {
                _context.Tecnicos.Remove(tecnico);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool TecnicoExists(int id)
        {
            return _context.Tecnicos.Any(t => t.TecnicoID == id);
        }
    }
}
