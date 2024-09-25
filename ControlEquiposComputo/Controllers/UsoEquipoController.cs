using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlEquiposComputo.Data; 
using ControlEquiposComputo.Models; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

public class UsoEquipoController : Controller
{
    private readonly AppDbContext _context;

    public UsoEquipoController(AppDbContext context)
    {
        _context = context;
    }

    // GET: UsoEquipos
    public async Task<IActionResult> Index()
    {
        var usoEquipos = await _context.UsoEquipos
            .Include(u => u.Estudiante)
            .Include(u => u.Equipo)
            .Include(u => u.Clase)
            .ToListAsync();
        return View(usoEquipos);
    }

    // GET: UsoEquipos/Create
    public IActionResult Create()
    {
        UsoEquipo nuevoUsoEquipo = new UsoEquipo
        {
            FechaRegistro = DateTime.Now // Valor por defecto en el controlador
        };

        ViewData["EstudianteID"] = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre");
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo");
        ViewData["ClaseID"] = new SelectList(_context.Clases, "ClaseID", "NombreClase");
        return View(nuevoUsoEquipo);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(UsoEquipo usoEquipo, string DescripcionIncidente)
    {
        if (ModelState.IsValid)
        {
            _context.Add(usoEquipo);
            await _context.SaveChangesAsync();

            // Si el usuario desea registrar un incidente
            if (usoEquipo.RegistrarIncidente && !string.IsNullOrEmpty(DescripcionIncidente))
            {
                Incidente incidente = new Incidente
                {
                    UsoEquipoID = usoEquipo.UsoEquipoID,
                    FechaIncidente = DateTime.Now,
                    Descripcion = DescripcionIncidente,
                    Estado = "Pendiente"
                };
                _context.Add(incidente);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        ViewData["ClaseID"] = new SelectList(_context.Clases, "ClaseID", "NombreClase", usoEquipo.ClaseID);
        ViewData["EstudianteID"] = new SelectList(_context.Estudiantes, "EstudianteID", "Nombre", usoEquipo.EstudianteID);
        ViewData["EquipoID"] = new SelectList(_context.Equipos, "EquipoID", "NumeroEquipo", usoEquipo.EquipoID);
        return View(usoEquipo);
    }


    // GET: UsoEquipos/Edit/5
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

    // POST: UsoEquipos/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, UsoEquipo usoEquipo)
    {
        if (id != usoEquipo.UsoEquipoID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
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

    // GET: UsoEquipos/Delete/5
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

    // POST: UsoEquipos/Delete/5
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
        return _context.UsoEquipos.Any(u => u.UsoEquipoID == id);
    }
}
