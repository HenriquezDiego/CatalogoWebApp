using CatalogoWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoWebApp.Controllers
{
    [Controller]
    public class EstadisticasController : Controller 
    {
        private readonly IUnitOfWork _unitOfWork;

        public EstadisticasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Facultad()
        {
            var trabajos = await _unitOfWork.GetTrabajosDeGraduacionIncludes();

            var facultades = await _unitOfWork.Facultades.GetAllAsync();
            var result = facultades.Select(x => new SimpleReportViewModel()
                {
                    DimensionOne = x.Nombre,
                    Quantity = trabajos.Count(t => t.Autor.Carrera.FacultadId == x.Id)
                }).ToList();
            return View(result);
        }

        public async Task<IActionResult> Year()
        {
            var trabajos = await _unitOfWork.GetTrabajosDeGraduacionIncludes();
            var result =  trabajos.OrderBy(t=>t.Fecha.Year)
                .ToList()
                .GroupBy(t => t.Fecha.Year)
                .Select((x) => new SimpleReportViewModel()
                {
                    DimensionOne = x.Key.ToString(),
                    Quantity = x.Count(t=>t.Fecha.Year == x.Key)
                }).ToList();

            return View(result);
        }

        public async Task<IActionResult> Tipo()
        {
            var trabajos = await _unitOfWork.GetTrabajosDeGraduacionIncludes();
            var result = trabajos
                .OrderBy(t => t.Tipo.Nombre)
                .ToList()
                .GroupBy(t => t.Tipo.Nombre)
                .Select(x => new SimpleReportViewModel
                {
                    DimensionOne = x.Key,
                    Quantity = x.Count(t => t.Tipo.Nombre == x.Key)
                }).ToList();

            return View(result);

        }

    }
}

public class SimpleReportViewModel
{
    public string DimensionOne { get; set; }  
    public int Quantity { get; set; }  
}  
