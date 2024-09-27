using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;


[Authorize]
public class TecnicoController : Controller
{
    private readonly AppDbContext _context;

    public TecnicoController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Tecnicos
    public async Task<IActionResult> Index()
    {
        var tecnicos = await _context.Tecnicos.ToListAsync();
        return View(tecnicos);
    }

    // GET: Tecnicos/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Tecnicos/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Tecnico tecnico)
    {
        if (ModelState.IsValid)
        {
            _context.Add(tecnico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(tecnico);
    }

    // GET: Tecnicos/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var tecnico = await _context.Tecnicos.FindAsync(id);
        if (tecnico == null)
        {
            return NotFound();
        }
        return View(tecnico);
    }

    // POST: Tecnicos/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Tecnico tecnico)
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

    // GET: Tecnicos/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var tecnico = await _context.Tecnicos.FindAsync(id);
        if (tecnico == null)
        {
            return NotFound();
        }
        return View(tecnico);
    }

    // POST: Tecnicos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var tecnico = await _context.Tecnicos.FindAsync(id);
        _context.Tecnicos.Remove(tecnico);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TecnicoExists(int id)
    {
        return _context.Tecnicos.Any(e => e.TecnicoID == id);
    }
}
