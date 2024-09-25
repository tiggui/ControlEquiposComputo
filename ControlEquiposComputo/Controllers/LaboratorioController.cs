using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;

public class LaboratorioController : Controller
{
    private readonly AppDbContext _context;

    public LaboratorioController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Laboratorios
    public async Task<IActionResult> Index()
    {
        var laboratorios = await _context.Laboratorios.ToListAsync();
        return View(laboratorios);
    }

    // GET: Laboratorios/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Laboratorios/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Laboratorio laboratorio)
    {
        if (ModelState.IsValid)
        {
            _context.Add(laboratorio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(laboratorio);
    }

    // GET: Laboratorios/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var laboratorio = await _context.Laboratorios.FindAsync(id);
        if (laboratorio == null)
        {
            return NotFound();
        }
        return View(laboratorio);
    }

    // POST: Laboratorios/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Laboratorio laboratorio)
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

    // GET: Laboratorios/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var laboratorio = await _context.Laboratorios.FindAsync(id);
        if (laboratorio == null)
        {
            return NotFound();
        }
        return View(laboratorio);
    }

    // POST: Laboratorios/Delete/5
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
