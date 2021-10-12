using System;
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
using Microsoft.Extensions.Logging;
using TransaccionesWebApi.Services;

namespace CatalogoWebApp.Controllers
{
    public class TrabajosDeGraduacionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileService _file;
        private readonly ILogger<TrabajosDeGraduacionController> _logger;
        private readonly List<AutorViewModel> _autores;
        private readonly List<int> _years;
        public TrabajosDeGraduacionController(AppDbContext context, 
            IMapper mapper,
            IFileService file,
            ILogger<TrabajosDeGraduacionController> logger)
        {
            _context = context;
            _mapper = mapper;
            _file = file;
            _logger = logger;
            _autores = mapper.Map<List<AutorViewModel>>(_context.Autores.ToList());
            var totalYear = DateTime.Today.Year;
            var init = 1995;
            _years =  Enumerable.Repeat(0, totalYear-init).ToList();
            _years = _years.Select(x =>
            {
                init += 1;
                return init;
            }).ToList();
        }

        // GET: TrabajosDeGraduacion
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.TrabajosDeGraduacion
                .Include(t => t.Autor)
                .ThenInclude(t=>t.Carrera)
                .Include(t => t.Tipo);
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
            ViewData["Years"] = new SelectList(_years,_years.FirstOrDefault());
            return View();
        }

        // POST: TrabajosDeGraduacion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TrabajoDeGraduacionInput model)
        {
            _logger.LogInformation("Iniciado..."+ nameof(Create));
            if (ModelState.IsValid)
            {
                var trabajoDeGraduacion = _mapper.Map<TrabajoDeGraduacion>(model);
                var fileName = "/img/thesis.png";
                if (model.Imagen != null)
                {
                    fileName = await _file.Upload(model.Imagen, model.Titulo);
                }

                if (model.File != null)
                {
                    trabajoDeGraduacion.PathFile = await _file.Upload(model.File, model.Titulo);
                }
                trabajoDeGraduacion.PathImagen = fileName;
                _context.Add(trabajoDeGraduacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", model.AutorId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "TipoId", "TipoId", model.TipoId);
            ViewData["Years"] = new SelectList(_years,_years.FirstOrDefault());
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
            ViewData["Years"] = new SelectList(_years,_years.FirstOrDefault());
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
                if (model.Imagen != null)
                {
                    var fileName = await _file.Upload(model.Imagen, model.Titulo);
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
                .FirstOrDefaultAsync(m => m.TrabajoDeGraduacionId == id);
            if (trabajoDeGraduacion == null)return NotFound();
            
            _context.TrabajosDeGraduacion.Remove(trabajoDeGraduacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

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
