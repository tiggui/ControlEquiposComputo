using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; // Cambia esto si es necesario
using ControlEquiposComputo.Models; // Cambia esto si es necesario
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;


[Authorize]
public class EstudianteController : Controller
{
    private readonly AppDbContext _context;

    public EstudianteController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Estudiantes
    public async Task<IActionResult> Index()
    {
        var estudiantes = await _context.Estudiantes.ToListAsync();
        return View(estudiantes);
    }

    // GET: Estudiantes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Estudiantes/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Estudiante estudiante)
    {
        if (ModelState.IsValid)
        {
            _context.Add(estudiante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(estudiante);
    }

    // GET: Estudiantes/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        if (estudiante == null)
        {
            return NotFound();
        }
        return View(estudiante);
    }

    // POST: Estudiantes/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Estudiante estudiante)
    {
        if (id != estudiante.EstudianteID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(estudiante);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudianteExists(estudiante.EstudianteID))
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
        return View(estudiante);
    }

    // GET: Estudiantes/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        if (estudiante == null)
        {
            return NotFound();
        }
        return View(estudiante);
    }

    // POST: Estudiantes/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        _context.Estudiantes.Remove(estudiante);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EstudianteExists(int id)
    {
        return _context.Estudiantes.Any(e => e.EstudianteID == id);
    }
}
