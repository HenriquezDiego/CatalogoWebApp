using System.Linq;
using CatalogoWebApp.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoWebApp.Controllers
{
    public class EstadisticasController : Controller 
    {
        private readonly AppDbContext _appDbContext;

        public EstadisticasController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult PorFacultad()
        {
            var trabajos = _appDbContext.TrabajosDeGraduacion
                .Include(t=> t.Autor)
                .ThenInclude(t=>t.Carrera)
                .ToList();
            var facultades = _appDbContext.Facultades
                .OrderBy(f=>f.Nombre)
                .Select(f=>f.Nombre)
                .ToList();

            var data = _appDbContext.Facultades
                .OrderBy(f=>f.Nombre)
                .ToList()
                    .Select(f => new
                    {
                        TrabajosDeGraduacion = trabajos
                        .Count(t=> t.Autor.Carrera.FacultadId == f.FacultadId)
                    });

            return Json(new { facultades, data });
        }

        public IActionResult Grafico()
        {
            return View("PorFacultad");
        }

    }
}
