using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlEquiposComputo.Controllers
{
    public class UsoEquipoController : Controller
    {
        private readonly AppDbContext _context;

        public UsoEquipoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UsoEquipo
        public async Task<IActionResult> Index()
        {
            var usoEquipos = _context.UsoEquipos.Include(u => u.Equipo).Include(u => u.Usuario);
            return View(await usoEquipos.ToListAsync());
        }

        // GET: UsoEquipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usoEquipo = await _context.UsoEquipos
                .Include(u => u.Equipo)
                .Include(u => u.Usuario)
                .FirstOrDefaultAsync(m => m.UsoEquipoID == id);
            if (usoEquipo == null)
            {
                return NotFound();
            }

            return View(usoEquipo);
        }

        // GET: UsoEquipo/Create
        public IActionResult Create()
        {
            ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "Marca"); // Modifica según lo que desees mostrar
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre"); // Modifica según lo que desees mostrar
            return View();
        }

        // POST: UsoEquipo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsoEquipoID,EquipoID,UsuarioID,FechaUso,HoraInicio,HoraFin,Actividad")] UsoEquipo usoEquipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usoEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "Marca", usoEquipo.EquipoID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre", usoEquipo.UsuarioID);
            return View(usoEquipo);
        }

        // GET: UsoEquipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usoEquipo = await _context.UsoEquipos.FindAsync(id);
            if (usoEquipo == null)
            {
                return NotFound();
            }
            ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "Marca", usoEquipo.EquipoID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre", usoEquipo.UsuarioID);
            return View(usoEquipo);
        }

        // POST: UsoEquipo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsoEquipoID,EquipoID,UsuarioID,FechaUso,HoraInicio,HoraFin,Actividad")] UsoEquipo usoEquipo)
        {
            if (id != usoEquipo.UsoEquipoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usoEquipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsoEquipoExists(usoEquipo.UsoEquipoID))
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
            ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "Marca", usoEquipo.EquipoID);
            ViewData["UsuarioID"] = new SelectList(_context.Usuarios, "UsuarioID", "Nombre", usoEquipo.UsuarioID);
            return View(usoEquipo);
        }

        // GET: UsoEquipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usoEquipo = await _context.UsoEquipos
                .Include(u => u.Equipo)
                .Include(u => u.Usuario)
                .FirstOrDefaultAsync(m => m.UsoEquipoID == id);
            if (usoEquipo == null)
            {
                return NotFound();
            }

            return View(usoEquipo);
        }

        // POST: UsoEquipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usoEquipo = await _context.UsoEquipos.FindAsync(id);
            if (usoEquipo != null)
            {
                _context.UsoEquipos.Remove(usoEquipo);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool UsoEquipoExists(int id)
        {
            return _context.UsoEquipos.Any(u => u.UsoEquipoID == id);
        }
    }
}
