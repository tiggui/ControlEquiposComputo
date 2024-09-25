using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ClaseController : Controller
{
    private readonly AppDbContext _context;

    public ClaseController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Clases
    public async Task<IActionResult> Index()
    {
        var clases = await _context.Clases.Include(c => c.Docente).Include(c => c.Laboratorio).ToListAsync();
        return View(clases);
    }

    // GET: Clases/Create
    public IActionResult Create()
    {
        ViewData["DocenteID"] = new SelectList(_context.Docentes, "DocenteID", "Nombre");
        ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio");
        return View();
    }

    // POST: Clases/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Clase clase)
    {
        if (ModelState.IsValid)
        {
            _context.Add(clase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["DocenteID"] = new SelectList(_context.Docentes, "DocenteID", "Nombre", clase.DocenteID);
        ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", clase.LaboratorioID);
        return View(clase);
    }

    // GET: Clases/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var clase = await _context.Clases.FindAsync(id);
        if (clase == null)
        {
            return NotFound();
        }
        ViewData["DocenteID"] = new SelectList(_context.Docentes, "DocenteID", "Nombre", clase.DocenteID);
        ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", clase.LaboratorioID);
        return View(clase);
    }

    // POST: Clases/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Clase clase)
    {
        if (id != clase.ClaseID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(clase);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaseExists(clase.ClaseID))
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
        ViewData["DocenteID"] = new SelectList(_context.Docentes, "DocenteID", "Nombre", clase.DocenteID);
        ViewData["LaboratorioID"] = new SelectList(_context.Laboratorios, "LaboratorioID", "NombreLaboratorio", clase.LaboratorioID);
        return View(clase);
    }

    // GET: Clases/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var clase = await _context.Clases.Include(c => c.Docente).Include(c => c.Laboratorio).FirstOrDefaultAsync(m => m.ClaseID == id);
        if (clase == null)
        {
            return NotFound();
        }
        return View(clase);
    }

    // POST: Clases/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var clase = await _context.Clases.FindAsync(id);
        _context.Clases.Remove(clase);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ClaseExists(int id)
    {
        return _context.Clases.Any(e => e.ClaseID == id);
    }
}
