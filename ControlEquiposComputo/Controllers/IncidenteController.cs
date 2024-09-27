using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;


[Authorize]
public class IncidenteController : Controller
{
    private readonly AppDbContext _context;

    public IncidenteController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Incidentes
    public async Task<IActionResult> Index()
    {
        var incidentes = await _context.Incidentes
            .Include(i => i.UsoEquipo)
                .ThenInclude(u => u.Estudiante)
            .Include(i => i.UsoEquipo)
                .ThenInclude(u => u.Equipo)
            .Include(i => i.UsoEquipo)
                .ThenInclude(u => u.Clase)
            .ToListAsync();
        return View(incidentes);
    }

    // GET: Incidentes/Create
    public IActionResult Create()
    {
        ViewData["UsoEquipoID"] = new SelectList(_context.UsoEquipos.Include(u => u.Estudiante), "UsoEquipoID", "Actividad");
        return View();
    }

    // POST: Incidentes/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Incidente incidente)
    {
        if (ModelState.IsValid)
        {
            _context.Add(incidente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["UsoEquipoID"] = new SelectList(_context.UsoEquipos, "UsoEquipoID", "Actividad", incidente.UsoEquipoID);
        return View(incidente);
    }

    // GET: Incidentes/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var incidente = await _context.Incidentes.FindAsync(id);
        if (incidente == null)
        {
            return NotFound();
        }
        ViewData["UsoEquipoID"] = new SelectList(_context.UsoEquipos, "UsoEquipoID", "Actividad", incidente.UsoEquipoID);
        return View(incidente);
    }

    // POST: Incidentes/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Incidente incidente)
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
        ViewData["UsoEquipoID"] = new SelectList(_context.UsoEquipos, "UsoEquipoID", "Actividad", incidente.UsoEquipoID);
        return View(incidente);
    }

    // GET: Incidentes/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var incidente = await _context.Incidentes
            .Include(i => i.UsoEquipo)
                .ThenInclude(u => u.Estudiante)
            .Include(i => i.UsoEquipo)
                .ThenInclude(u => u.Equipo)
            .Include(i => i.UsoEquipo)
                .ThenInclude(u => u.Clase)
            .FirstOrDefaultAsync(i => i.IncidenteID == id);
        if (incidente == null)
        {
            return NotFound();
        }
        return View(incidente);
    }

    // POST: Incidentes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var incidente = await _context.Incidentes.FindAsync(id);
        _context.Incidentes.Remove(incidente);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool IncidenteExists(int id)
    {
        return _context.Incidentes.Any(i => i.IncidenteID == id);
    }
}
