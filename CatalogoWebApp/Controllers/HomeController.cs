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
                .ThenInclude(t=>t.Carrera)
                .OrderBy(t=>t.Titulo)
                .ToListAsync();
            search = search?.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                trabajosDeGraduacion = trabajosDeGraduacion.Where(t =>
                    t.Descripcion.ToLower().Contains(search) || t.Autor.Nombres.ToLower().Contains(search) ||
                    t.Autor.Apellidos.ToLower().Contains(search)||t.Fecha.Year.ToString() == search).ToList();
            }
            return View(trabajosDeGraduacion);
        }

        public IActionResult Table()
        {

            return View();
        }
    }
}