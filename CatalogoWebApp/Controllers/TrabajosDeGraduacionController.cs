using AutoMapper;
using CatalogoWebApp.Inputs;
using CatalogoWebApp.Services;
using CatalogoWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransaccionesWebApi.Services;

namespace CatalogoWebApp.Controllers
{
    public class TrabajosDeGraduacionController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileService _file;
        private readonly ILogger<TrabajosDeGraduacionController> _logger;
        private readonly List<AutorViewModel> _autores;
        private readonly List<int> _years;
        private readonly IUnitOfWork _unitOfWork;
        public TrabajosDeGraduacionController( 
            IMapper mapper,
            IFileService file,
            ILogger<TrabajosDeGraduacionController> logger, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _file = file;
            _logger = logger;
            _autores = mapper.Map<List<AutorViewModel>>(_unitOfWork.Autores.GetAll());
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
            var trabajosDeGraduacion = await _unitOfWork.GetTrabajosDeGraduacionIncludes();
            return View(trabajosDeGraduacion);
        }

        // GET: TrabajosDeGraduacion/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();

            var trabajoDeGraduacion = await _unitOfWork.GetTrabajoDeGraduacionIncludes(id);
            if (trabajoDeGraduacion == null) return NotFound();
            return View(trabajoDeGraduacion);
        }

        // GET: TrabajosDeGraduacion/Create
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info");
            ViewData["TipoId"] = new SelectList(_unitOfWork.Tipos.GetAll(), "TipoId", "Nombre");
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
                var trabajoDeGraduacion = _mapper.Map<Models.NoSQL.TrabajoDeGraduacion>(model);
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
                await _unitOfWork.TrabajosDeGraduacion.CreateAsync(trabajoDeGraduacion);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", model.AutorId);
            ViewData["TipoId"] = new SelectList(await _unitOfWork.Tipos.GetAllAsync(), "TipoId", "Nombre", model.TipoId);
            ViewData["Years"] = new SelectList(_years,_years.FirstOrDefault());
            return View(model);
        }

        // GET: TrabajosDeGraduacion/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) return NotFound();
            var trabajoDeGraduacion = await _unitOfWork.TrabajosDeGraduacion.GetAsync(id);
            if (trabajoDeGraduacion == null)
            {
                return NotFound();
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", trabajoDeGraduacion.AutorId);
            ViewData["TipoId"] = new SelectList(await _unitOfWork.Tipos.GetAllAsync(), "TipoId", "Nombre", trabajoDeGraduacion.TipoId);
            ViewData["Years"] = new SelectList(_years,_years.FirstOrDefault());
            var value = _mapper.Map<TrabajoDeGraduacionInput>(trabajoDeGraduacion);
            return View(value);
        }

        // POST: TrabajosDeGraduacion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,TrabajoDeGraduacionInput model)
        {
            var trabajo = await _unitOfWork.TrabajosDeGraduacion.GetAsync(id);
            if (trabajo == null) return NotFound();
            if (ModelState.IsValid)
            {
                
                _mapper.Map(model, trabajo);
                if (model.Imagen == null) return RedirectToAction(nameof(Index));
                var fileName = await _file.Upload(model.Imagen, model.Titulo);
                trabajo.PathImagen = fileName;
                await _unitOfWork.TrabajosDeGraduacion.UpdateAsync(id,trabajo);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_autores, "AutorId", "Info", model.AutorId);
            ViewData["TipoId"] = new SelectList(await _unitOfWork.Tipos.GetAllAsync(), "TipoId", "TipoId", model.TipoId);
            var value = _mapper.Map<TrabajoDeGraduacionInput>(model);
            return View(value);
        }

        // GET: TrabajosDeGraduacion/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if(string.IsNullOrEmpty(id)) return NotFound();
            var trabajoDeGraduacion = await _unitOfWork.TrabajosDeGraduacion.GetAsync(id);
            if (trabajoDeGraduacion == null)return NotFound();
            await _unitOfWork.TrabajosDeGraduacion.RemoveAsync(id);
            return RedirectToAction(nameof(Index));

        }

        // POST: TrabajosDeGraduacion/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var trabajoDeGraduacion = await _context.TrabajosDeGraduacion.FindAsync(id);
        //    _context.TrabajosDeGraduacion.Remove(trabajoDeGraduacion);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

    }
}
