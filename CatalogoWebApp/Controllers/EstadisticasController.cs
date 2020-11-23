using CatalogoWebApp.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatalogoWebApp.Controllers
{
    [Controller]
    public class EstadisticasController : Controller 
    {
        private readonly AppDbContext _appDbContext;

        public EstadisticasController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Facultad()
        {
            var trabajos = _appDbContext.TrabajosDeGraduacion
                .Include(t=>t.Autor)
                .ThenInclude(t=>t.Carrera)
                .ToList();
            var lstModel = _appDbContext.Facultades
                .ToList().Select(x => new SimpleReportViewModel()
            {
                DimensionOne = x.Nombre,
                Quantity = trabajos.Count(t => t.Autor.Carrera.FacultadId == x.FacultadId)
            }).ToList();
            return View(lstModel);
        }

        public IActionResult FacultadCarrera(int facultadId)
        {
            if (facultadId > 0)
            {
                var carreras = _appDbContext.Carreras.Where(c => c.FacultadId == facultadId)
                    .OrderBy(t=>t.Nombre)
                    .ToList();

                var trabajoss = _appDbContext.TrabajosDeGraduacion
                    .Include(t=>t.Autor)
                    .ThenInclude(t=>t.Carrera)
                    .Where(t=>t.Autor.Carrera.FacultadId == facultadId)
                    .OrderBy(t => t.Autor.Carrera.Nombre)
                    .ToList();

                var cantidades = carreras.Select(c => trabajoss.Count(t => t.Autor.CarreraId == c.CarreraId)).ToList();

                
                return Json(new {carreras = carreras.Select(c => c.Nombre).ToList(),cantidades});
            }
            var trabajos = _appDbContext.TrabajosDeGraduacion
                .Include(t => t.Autor)
                .ThenInclude(t => t.Carrera)
                .ToList();

            var lstModel = _appDbContext.Carreras
                .Where(c => c.FacultadId == 600)
                .ToList()
                .Select(x => new SimpleReportViewModel()
                {
                    DimensionOne = x.Nombre,
                    Quantity = trabajos.Count(t => t.Autor.CarreraId == x.CarreraId)
                })
                .OrderBy(f => f.DimensionOne)
                .ToList();

            var facultades = _appDbContext.Facultades.ToList().OrderBy(f => f.Nombre);

            ViewData["FacultadId"] = new SelectList(facultades, "FacultadId", "Nombre",600);
            return View(lstModel);
        }

        public IActionResult Year()
        {
            var report = _appDbContext.TrabajosDeGraduacion
                .OrderBy(t=>t.Fecha.Year)
                .ToList()
                .GroupBy(t => t.Fecha.Year)
                .Select((x) => new SimpleReportViewModel()
                {
                    DimensionOne = x.Key.ToString(),
                    Quantity = x.Count(t=>t.Fecha.Year == x.Key)
                }).ToList();
            return View(report);
        }

    }
}

public class SimpleReportViewModel
{
    public string DimensionOne { get; set; }  
    public int Quantity { get; set; }  
}  
