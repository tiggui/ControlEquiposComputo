using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

public class EquipoController : Controller
{
    private readonly AppDbContext _context;

    public EquipoController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Equipos
    public async Task<IActionResult> Index()
    {
        var equipos = await _context.Equipos.Include(e => e.Laboratorio).ToListAsync();
        return View(equipos);
    }

    // GET: Equipos/Create
    public IActionResult Create()
    {
        ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio");
        return View();
    }

    // POST: Equipos/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Equipo equipo)
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

    // GET: Equipos/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var equipo = await _context.Equipos.FindAsync(id);
        if (equipo == null)
        {
            return NotFound();
        }
        ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", equipo.LaboratorioID);
        return View(equipo);
    }

    // POST: Equipos/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Equipo equipo)
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

    // GET: Equipos/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var equipo = await _context.Equipos.Include(e => e.Laboratorio).FirstOrDefaultAsync(m => m.EquipoID == id);
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo);
    }

    // POST: Equipos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var equipo = await _context.Equipos.FindAsync(id);
        _context.Equipos.Remove(equipo);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EquipoExists(int id)
    {
        return _context.Equipos.Any(e => e.EquipoID == id);
    }
}
