using CatalogoWebApp.DataAccess;
using CatalogoWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoWebApp.Controllers
{
    public class AutoresController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IList<Models.NoSQL.Carrera> _carreras;

        public AutoresController(AppDbContext context, 
            IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _carreras = _unitOfWork.Carreras.GetAll()?.OrderBy(c => c.Nombre).ToList();
        }

        [HttpGet("api/autores")]
        public IActionResult GetAll()
        {
            var autores = _context.Autores.ToList();
            if (!autores.Any()) return BadRequest();
            return Ok(autores.Select(x => new
            {
                x.Codigo,
                x.Nombres,
                x.Apellidos,
                Carrera = x.Carrera.Nombre,
            }));
        }

        // GET: Autores
        public async Task<IActionResult> Index()
        {
            var autores = await _unitOfWork.Autores.GetAllAsync();
            var query = from a in autores
                join c in _carreras on a.CarreraCodigo equals c.Codigo
                select new Models.NoSQL.Autor
                {
                    Id = a.Id,
                    Nombres = a.Nombres,
                    Codigo = a.Codigo,
                    Apellidos = a.Apellidos,
                    CarreraCodigo = a.CarreraCodigo,
                    Carrera = c
                };
            return View(query);

        }

        // GET: Autores/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id)) return NotFound();
            var autores = await _unitOfWork.Autores.GetAllAsync();
            var query = from a in autores
                join c in _carreras on a.CarreraCodigo equals c.Codigo
                select new Models.NoSQL.Autor
                {
                    Id = a.Id,
                    Nombres = a.Nombres,
                    Codigo = a.Codigo,
                    Apellidos = a.Apellidos,
                    CarreraCodigo = a.CarreraCodigo,
                    Carrera = c
                };
            return View(query.FirstOrDefault(a=>a.Id == id));
        }

        // GET: Autores/Create
        public IActionResult Create()
        {
            ViewData["CarreraId"] = new SelectList(_carreras, "Codigo", "Nombre");
            return View();
        }

        // POST: Autores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nombres,Apellidos,CarreraCodigo")] Models.NoSQL.Autor autor)
        {
            if (ModelState.IsValid) 
            {
                await _unitOfWork.Autores.CreateAsync(autor);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarreraId"] = new SelectList(_carreras, "Codigo", "Nombre", autor.CarreraCodigo);
            return View(autor);
        }

        // GET: Autores/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) return NotFound();
            var autor = await _unitOfWork.Autores.GetAsync(id);
            if (autor == null) return NotFound();
            ViewData["CarreraId"] = new SelectList(_carreras, "Codigo", "Nombre", autor.Id);
            return View(autor);
        }

        // POST: Autores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Codigo,Nombres,Apellidos,CarreraCodigo")] Models.NoSQL.Autor autor)
        {
            if (id != autor.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.Autores.UpdateAsync(id,autor);
                 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutorExists(autor.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarreraId"] = new SelectList(_carreras, "", "Nombre", autor.Id);
            return View(autor);
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _unitOfWork.Autores.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AutorExists(string id)
        {
            return  _unitOfWork.Autores.GetAsync(id).IsCompletedSuccessfully;
        }
    }
}
