using CatalogoWebApp.DataAccess;
using CatalogoWebApp.Models;
using CatalogoWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;
using Tipo = CatalogoWebApp.Models.NoSQL.Tipo;

namespace CatalogoWebApp.Controllers
{
    [ApiController]
    [Route("api/migration-json")]
    public class Value : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly StoreService<Tipo> _services;
        public Value(IOptions<StoreDatabaseSettings> settings,AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _services = new StoreService<Tipo>(settings);
        }

        [HttpGet("tipos")]
        public async Task<IActionResult> GetAll()
        {
          var result = await _services.GetAsync();
          return Ok(result);
        }

        [HttpGet("autores")]
        public IActionResult GetAutores()
        {
            var result = _appDbContext.Autores.Include(a => a.Carrera)
                .ToList()
                .Select(a=> new 
                {
                    a.Codigo,
                    a.Nombres,
                    a.NombreCompleto,
                    CarreraCodigo = a.Carrera.Codigo

                });
        return Ok(result);
        }

        [HttpGet("carreras")]
        public IActionResult GetCarreras()
        {
            var result = _appDbContext.Carreras.Include(c=>c.Facultad).ToList()
                .Select(c=> new
                {
                    c.Codigo,
                    c.Nombre,
                    Facultad = c.Facultad.Codigo
                });
            return Ok(result);
        }

        [HttpGet("facultades")]
        public IActionResult GetFacultades()
        {
            var result = _appDbContext.Facultades.ToList()
                .Select(f=>new
                {
                    f.Codigo,
                    f.Nombre
                });
        return Ok(result);
        }
    }
}
