using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;

public class DocenteController : Controller
{
    private readonly AppDbContext _context;

    public DocenteController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Docentes
    public async Task<IActionResult> Index()
    {
        var docentes = await _context.Docentes.ToListAsync();
        return View(docentes);
    }

    // GET: Docentes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Docentes/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Docente docente)
    {
        if (ModelState.IsValid)
        {
            _context.Add(docente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(docente);
    }

    // GET: Docentes/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var docente = await _context.Docentes.FindAsync(id);
        if (docente == null)
        {
            return NotFound();
        }
        return View(docente);
    }

    // POST: Docentes/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Docente docente)
    {
        if (id != docente.DocenteID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(docente);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocenteExists(docente.DocenteID))
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
        return View(docente);
    }

    // GET: Docentes/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var docente = await _context.Docentes.FindAsync(id);
        if (docente == null)
        {
            return NotFound();
        }
        return View(docente);
    }

    // POST: Docentes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var docente = await _context.Docentes.FindAsync(id);
        _context.Docentes.Remove(docente);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool DocenteExists(int id)
    {
        return _context.Docentes.Any(e => e.DocenteID == id);
    }
}
