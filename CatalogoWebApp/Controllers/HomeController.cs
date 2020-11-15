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
        public async Task<IActionResult> Index()
        {
            var trabajosDeGraduacion = await _appDbContext.TrabajosDeGraduacion
                .Include(t => t.Autor)
                .ThenInclude(t=>t.Carrera)
                .OrderBy(t=>t.Titulo)
                .ToListAsync();

            return View(trabajosDeGraduacion);
        }

        public IActionResult Table()
        {

            return View();
        }
    }
}