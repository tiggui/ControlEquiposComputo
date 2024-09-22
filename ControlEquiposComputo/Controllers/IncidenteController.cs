using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Models;
using ControlEquiposComputo.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlEquiposComputo.Controllers
{
    public class IncidenteController : Controller
    {
        private readonly AppDbContext _context;

        public IncidenteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Incidente
        public async Task<IActionResult> Index()
        {
            var incidentes = _context.Incidentes
                .Include(i => i.Laboratorio)
                .Include(i => i.Equipo)
                .Include(i => i.Tecnico)
                .Include(i => i.Usuario);
            return View(await incidentes.ToListAsync());
        }

        // GET: Incidente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes
                .Include(i => i.Laboratorio)
                .Include(i => i.Equipo)
                .Include(i => i.Tecnico)
                .Include(i => i.Usuario)
                .FirstOrDefaultAsync(i => i.IncidenteID == id);
            if (incidente == null)
            {
                return NotFound();
            }

            return View(incidente);
        }

        // GET: Incidente/Create
        public async Task<IActionResult> Create()
        {
            ViewData["LaboratorioID"] = new SelectList(await _context.Laboratorios.ToListAsync(), "LaboratorioID", "NombreLaboratorio");
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca");
            ViewData["UsuarioID"] = new SelectList(await _context.Usuarios.ToListAsync(), "UsuarioID", "Nombre");
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre");
            return View();
        }

        // POST: Incidente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncidenteID,LaboratorioID,EquipoID,UsuarioID,TecnicoID,FechaIncidente,Descripcion,Estado")] Incidente incidente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incidente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratorioID"] = new SelectList(await _context.Laboratorios.ToListAsync(), "LaboratorioID", "NombreLaboratorio", incidente.LaboratorioID);
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca", incidente.EquipoID);
            ViewData["UsuarioID"] = new SelectList(await _context.Usuarios.ToListAsync(), "UsuarioID", "Nombre", incidente.UsuarioID);
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre", incidente.TecnicoID);
            return View(incidente);
        }

        // GET: Incidente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente == null)
            {
                return NotFound();
            }

            ViewData["LaboratorioID"] = new SelectList(await _context.Laboratorios.ToListAsync(), "LaboratorioID", "NombreLaboratorio", incidente.LaboratorioID);
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca", incidente.EquipoID);
            ViewData["UsuarioID"] = new SelectList(await _context.Usuarios.ToListAsync(), "UsuarioID", "Nombre", incidente.UsuarioID);
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre", incidente.TecnicoID);
            return View(incidente);
        }

        // POST: Incidente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncidenteID,LaboratorioID,EquipoID,UsuarioID,TecnicoID,FechaIncidente,Descripcion,Estado")] Incidente incidente)
        {
            if (id != incidente.IncidenteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incidente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidenteExists(incidente.IncidenteID))
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
            ViewData["LaboratorioID"] = new SelectList(await _context.Laboratorios.ToListAsync(), "LaboratorioID", "NombreLaboratorio", incidente.LaboratorioID);
            ViewData["EquipoID"] = new SelectList(await _context.Equipos.ToListAsync(), "EquipoID", "Marca", incidente.EquipoID);
            ViewData["UsuarioID"] = new SelectList(await _context.Usuarios.ToListAsync(), "UsuarioID", "Nombre", incidente.UsuarioID);
            ViewData["TecnicoID"] = new SelectList(await _context.Tecnicos.ToListAsync(), "TecnicoID", "Nombre", incidente.TecnicoID);
            return View(incidente);
        }

        // GET: Incidente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incidente = await _context.Incidentes
                .Include(i => i.Laboratorio)
                .Include(i => i.Equipo)
                .Include(i => i.Tecnico)
                .Include(i => i.Usuario)
                .FirstOrDefaultAsync(i => i.IncidenteID == id);
            if (incidente == null)
            {
                return NotFound();
            }

            return View(incidente);
        }

        // POST: Incidente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incidente = await _context.Incidentes.FindAsync(id);
            if (incidente != null)
            {
                _context.Incidentes.Remove(incidente);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool IncidenteExists(int id)
        {
            return _context.Incidentes.Any(i => i.IncidenteID == id);
        }
    }
}
