using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data;
using ControlEquiposComputo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;


[Authorize]
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
        var usos = await _context.UsoEquipos
            .Include(u => u.Estudiante)
            .Include(u => u.Equipo)
            .Include(u => u.Clase)
            .ToListAsync();
        return View(usos);
    }

    // GET: UsoEquipo/Create
    public IActionResult Create()
    {
        ViewData["EstudianteID"] = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre");
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo");
        ViewData["ClaseID"] = new SelectList(_context.Clases, "ClaseID", "NombreClase");
        return View();
    }

    // POST: UsoEquipo/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(UsoEquipo usoEquipo, IFormFile imagenArchivo)
    {
        if (ModelState.IsValid)
        {
            // Manejo de la carga de la imagen
            if (imagenArchivo != null && imagenArchivo.Length > 0)
            {
                var uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                var fileName = Path.GetFileName(imagenArchivo.FileName);
                var filePath = Path.Combine(uploadDir, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imagenArchivo.CopyToAsync(stream);
                }
                usoEquipo.Imagen = "/images/" + fileName; // Ruta de la imagen
            }

            _context.Add(usoEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["EstudianteID"] = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre", usoEquipo.EstudianteID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", usoEquipo.EquipoID);
        ViewData["ClaseID"] = new SelectList(_context.Clases, "ClaseID", "NombreClase", usoEquipo.ClaseID);
        return View(usoEquipo);
    }

    // GET: UsoEquipo/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var usoEquipo = await _context.UsoEquipos.FindAsync(id);
        if (usoEquipo == null)
        {
            return NotFound();
        }
        ViewData["EstudianteID"] = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre", usoEquipo.EstudianteID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", usoEquipo.EquipoID);
        ViewData["ClaseID"] = new SelectList(_context.Clases, "ClaseID", "NombreClase", usoEquipo.ClaseID);
        return View(usoEquipo);
    }

    // POST: UsoEquipo/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, UsoEquipo usoEquipo, IFormFile imagenArchivo)
    {
        if (id != usoEquipo.UsoEquipoID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                // Manejo de la carga de la imagen
                if (imagenArchivo != null && imagenArchivo.Length > 0)
                {
                    var uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    var fileName = Path.GetFileName(imagenArchivo.FileName);
                    var filePath = Path.Combine(uploadDir, fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imagenArchivo.CopyToAsync(stream);
                    }
                    usoEquipo.Imagen = "/images/" + fileName; // Actualiza la ruta de la imagen
                }

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
        ViewData["EstudianteID"] = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre", usoEquipo.EstudianteID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", usoEquipo.EquipoID);
        ViewData["ClaseID"] = new SelectList(_context.Clases, "ClaseID", "NombreClase", usoEquipo.ClaseID);
        return View(usoEquipo);
    }

    // GET: UsoEquipo/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var usoEquipo = await _context.UsoEquipos
            .Include(u => u.Estudiante)
            .Include(u => u.Equipo)
            .Include(u => u.Clase)
            .FirstOrDefaultAsync(u => u.UsoEquipoID == id);
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
        _context.UsoEquipos.Remove(usoEquipo);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool UsoEquipoExists(int id)
    {
        return _context.UsoEquipos.Any(e => e.UsoEquipoID == id);
    }
}
