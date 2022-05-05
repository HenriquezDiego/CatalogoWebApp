using CatalogoWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(string search)
        {
            var trabajosDeGraduacion = await _unitOfWork.GetTrabajosDeGraduacionIncludes();

            search = search?.ToLower().Trim();
            if (!string.IsNullOrEmpty(search))
            {
                trabajosDeGraduacion = trabajosDeGraduacion.Where(t =>
                    t.Titulo.ToLower().Contains(search) ||
                    t.Descripcion.ToLower().Contains(search) ||
                    t.Autor.NombreCompleto.ToLower().Contains(search) || 
                    t.Autor.Carrera.Nombre.ToLower().Contains(search) ||
                    t.Fecha.Year.ToString() == search).ToList();
            }
            return View(trabajosDeGraduacion
                .OrderBy(t=>t.Autor.NombreCompleto)
                .ThenBy(t=>t.Fecha.Year)
                .ToList());
        }

        public IActionResult Table()
        {

            return View();
        }
    }
}