using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_UTH.Models;

namespace Sistema_UTH.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly Sistema_UTHContext _context;

        public EstudiantesController(Sistema_UTHContext context)
        {
            _context = context;
        }

        // GET: Estudiantes
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NombreSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewData["ApellidoPaternoSortParm"] = sortOrder == "ap_asc" ? "ap_desc" : "ap_asc";
            ViewData["ApellidoMaternoSortParm"] = sortOrder == "am_asc" ? "am_desc" : "am_asc";
            ViewData["CurrentFilter"] = searchString;
            var estudiante = from s in _context.Estudiante select s;

            //Verifica que el término de búsqueda trae searchstring si trae alguno, y verificar si contiene un nombre o descripcion.
            if (!String.IsNullOrEmpty(searchString))
            {
                estudiante = estudiante.Where(s => s.Nombre.Contains(searchString) || s.ApellidoPaterno.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "nombre_desc":
                    estudiante = estudiante.OrderByDescending(s => s.Nombre);
                    break;
                case "ap_asc":
                    estudiante = estudiante.OrderBy(s => s.ApellidoPaterno);
                    break;
                case "am_desc":
                    estudiante = estudiante.OrderByDescending(s => s.ApellidoMaterno);
                    break;
                default:
                    estudiante = estudiante.OrderBy(s => s.Nombre);
                    break;
            }
            return View(await _context.Estudiante.ToListAsync());
        }

        // GET: Estudiantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante
                .FirstOrDefaultAsync(m => m.EstudianteId == id);
            if (estudiante == null)
            {
                return NotFound();
            }

            return View(estudiante);
        }

        // GET: Estudiantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudiantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstudianteId,Nombre,ApellidoPaterno,ApellidoMaterno")] Estudiante estudiante)
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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FindAsync(id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        // POST: Estudiantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstudianteId,Nombre,ApellidoPaterno,ApellidoMaterno")] Estudiante estudiante)
        {
            if (id != estudiante.EstudianteId)
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
                    if (!EstudianteExists(estudiante.EstudianteId))
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante
                .FirstOrDefaultAsync(m => m.EstudianteId == id);
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
            var estudiante = await _context.Estudiante.FindAsync(id);
            _context.Estudiante.Remove(estudiante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudianteExists(int id)
        {
            return _context.Estudiante.Any(e => e.EstudianteId == id);
        }
    }
}