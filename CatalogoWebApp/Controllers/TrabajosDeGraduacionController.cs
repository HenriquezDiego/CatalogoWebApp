using AutoMapper;
using CatalogoWebApp.DataAccess;
using CatalogoWebApp.Inputs;
using CatalogoWebApp.Models;
using CatalogoWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransaccionesWebApi.Services;

namespace CatalogoWebApp.Controllers
{
    public class TrabajosDeGraduacionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileService _file;
        private readonly List<AutorViewModel> _autores;
        public TrabajosDeGraduacionController(AppDbContext context, 
            IMapper mapper,
            IFileService file)
        {
            _context = context;
            _mapper = mapper;
            _file = file;
            _autores = mapper.Map<List<AutorViewModel>>(_context.Autores.ToList());
        }

        // GET: TrabajosDeGraduacion
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.TrabajosDeGraduacion
                .Include(t => t.Autor).Include(t => t.Tipo);
            return View(await appDbContext.ToListAsync());
        }

        // GET: TrabajosDeGraduacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajoDeGraduacion = await _context.TrabajosDeGraduacion
                .Include(t => t.Autor)
                .ThenInclude(t=>t.Carrera)
                .ThenInclude(t=>t.Facultad)
                .Include(t => t.Tipo)
                .FirstOrDefaultAsync(m => m.TrabajoDeGraduacionId == id);
            if (trabajoDeGraduacion == null)
            {
                return NotFound();
            }

            return View(trabajoDeGraduacion);
        }

        // GET: TrabajosDeGraduacion/Create
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info");
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId");
            return View();
        }

        // POST: TrabajosDeGraduacion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TrabajoDeGraduacionInput model)
        {
            if (ModelState.IsValid)
            {
                var trabajoDeGraduacion = _mapper.Map<TrabajoDeGraduacion>(model);
                var fileName = string.Empty;
                if (model.Imagen != null)
                {
                    fileName = await _file.Upload(model.Imagen, model.Titulo);
                }
                trabajoDeGraduacion.PathImagen = fileName;
                _context.Add(trabajoDeGraduacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", model.AutorId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", model.TipoId);
            return View(model);
        }

        // GET: TrabajosDeGraduacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajoDeGraduacion = await _context.TrabajosDeGraduacion.FindAsync(id);
            if (trabajoDeGraduacion == null)
            {
                return NotFound();
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", trabajoDeGraduacion.AutorId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", trabajoDeGraduacion.TipoId);
            var value = _mapper.Map<TrabajoDeGraduacionInput>(trabajoDeGraduacion);
            return View(value);
        }

        // POST: TrabajosDeGraduacion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,TrabajoDeGraduacionInput model)
        {
            var trabajoDeGraduacionOld = await _context.TrabajosDeGraduacion.FindAsync(id);
            if (trabajoDeGraduacionOld == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                _mapper.Map(model, trabajoDeGraduacionOld);
                var fileName = string.Empty;
                if (model.Imagen != null)
                {
                    fileName = await _file.Upload(model.Imagen, model.Titulo);
                    trabajoDeGraduacionOld.PathImagen = fileName;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", model.AutorId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", model.TipoId);
            var value = _mapper.Map<TrabajoDeGraduacionInput>(model);
            return View(value);
        }

        // GET: TrabajosDeGraduacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabajoDeGraduacion = await _context.TrabajosDeGraduacion
                .Include(t => t.Autor)
                .Include(t => t.Tipo)
                .FirstOrDefaultAsync(m => m.TrabajoDeGraduacionId == id);
            if (trabajoDeGraduacion == null)
            {
                return NotFound();
            }

            return View(trabajoDeGraduacion);
        }

        // POST: TrabajosDeGraduacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trabajoDeGraduacion = await _context.TrabajosDeGraduacion.FindAsync(id);
            _context.TrabajosDeGraduacion.Remove(trabajoDeGraduacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
