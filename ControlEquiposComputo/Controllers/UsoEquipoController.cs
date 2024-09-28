using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data;
using ControlEquiposComputo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        ViewBag.EstudianteID = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre");
        ViewBag.EquipoID = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo");
        ViewBag.ClaseID = new SelectList(_context.Clases, "ClaseID", "NombreClase");
        return View();
    }

    // POST: UsoEquipo/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(UsoEquipo usoEquipo, IFormFile imagenFile)
    {
        if (ModelState.IsValid)
        {
            // Manejo del archivo de imagen
            if (imagenFile != null && imagenFile.Length > 0)
            {
                var fileName = Path.GetFileName(imagenFile.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imagenFile.CopyToAsync(stream);
                }
                usoEquipo.Imagen = $"/images/{fileName}"; // Almacena la ruta relativa de la imagen
            }

            _context.Add(usoEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewBag.EstudianteID = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre", usoEquipo.EstudianteID);
        ViewBag.EquipoID = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", usoEquipo.EquipoID);
        ViewBag.ClaseID = new SelectList(_context.Clases, "ClaseID", "NombreClase", usoEquipo.ClaseID);
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
    public async Task<IActionResult> Edit(int id, UsoEquipo usoEquipo, IFormFile imagenFile)
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
                if (imagenFile != null && imagenFile.Length > 0)
                {
                    var uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    var fileName = Path.GetFileName(imagenFile.FileName);
                    var filePath = Path.Combine(uploadDir, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imagenFile.CopyToAsync(stream);
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
