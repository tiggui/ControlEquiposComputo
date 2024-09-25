using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

public class MantenimientoController : Controller
{
    private readonly AppDbContext _context;

    public MantenimientoController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Mantenimientos
    public async Task<IActionResult> Index()
    {
        var mantenimientos = await _context.Mantenimientos
            .Include(m => m.Tecnico)
            .Include(m => m.Equipo)
            .ToListAsync();
        return View(mantenimientos);
    }

    // GET: Mantenimientos/Create
    public IActionResult Create()
    {
        ViewData["TecnicoID"] = new SelectList(_context.Tecnicos, "TecnicoID", "Nombre");
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo");
        return View();
    }

    // POST: Mantenimientos/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Mantenimiento mantenimiento)
    {
        if (ModelState.IsValid)
        {
            _context.Add(mantenimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["TecnicoID"] = new SelectList(_context.Tecnicos, "TecnicoID", "Nombre", mantenimiento.TecnicoID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", mantenimiento.EquipoID);
        return View(mantenimiento);
    }

    // GET: Mantenimientos/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var mantenimiento = await _context.Mantenimientos.FindAsync(id);
        if (mantenimiento == null)
        {
            return NotFound();
        }
        ViewData["TecnicoID"] = new SelectList(_context.Tecnicos, "TecnicoID", "Nombre", mantenimiento.TecnicoID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", mantenimiento.EquipoID);
        return View(mantenimiento);
    }

    // POST: Mantenimientos/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Mantenimiento mantenimiento)
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
        ViewData["TecnicoID"] = new SelectList(_context.Tecnicos, "TecnicoID", "Nombre", mantenimiento.TecnicoID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", mantenimiento.EquipoID);
        return View(mantenimiento);
    }

    // GET: Mantenimientos/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var mantenimiento = await _context.Mantenimientos
            .Include(m => m.Tecnico)
            .Include(m => m.Equipo)
            .FirstOrDefaultAsync(m => m.MantenimientoID == id);
        if (mantenimiento == null)
        {
            return NotFound();
        }
        return View(mantenimiento);
    }

    // POST: Mantenimientos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var mantenimiento = await _context.Mantenimientos.FindAsync(id);
        _context.Mantenimientos.Remove(mantenimiento);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MantenimientoExists(int id)
    {
        return _context.Mantenimientos.Any(e => e.MantenimientoID == id);
    }
}
