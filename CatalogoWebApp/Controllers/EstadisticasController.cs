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

        public IActionResult Tipo()
        {
            var report = _appDbContext.TrabajosDeGraduacion
                .Include(t => t.Tipo)
                .OrderBy(t => t.Tipo.Nombre)
                .ToList()
                .GroupBy(t => t.Tipo.Nombre)
                .Select(x => new SimpleReportViewModel
                {
                    DimensionOne = x.Key,
                    Quantity = x.Count(t => t.Tipo.Nombre == x.Key)
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
