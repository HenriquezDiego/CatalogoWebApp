using System.Linq;
using System.Threading.Tasks;
using CatalogoWebApp.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index(string search)
        {
            var trabajosDeGraduacion = await _appDbContext.TrabajosDeGraduacion
                .Include(t => t.Autor)
                .ThenInclude(t => t.Carrera)
                .ToListAsync();

            search = search?.ToLower().Trim();
            if (!string.IsNullOrEmpty(search))
            {
                trabajosDeGraduacion = trabajosDeGraduacion.Where(t =>
                    t.Titulo.ToLower().Contains(search) ||
                    t.Descripcion.ToLower().Contains(search) ||
                    t.Autor.NombreCompleto.ToLower().Contains(search) || 
                    t.Autor.Carrera.Nombre.ToLower().Contains(search)).ToList();
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