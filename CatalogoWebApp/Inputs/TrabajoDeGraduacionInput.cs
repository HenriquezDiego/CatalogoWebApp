using CatalogoWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace CatalogoWebApp.Inputs
{
    public class TrabajoDeGraduacionInput
    {
        public string Titulo { get; set; }
        public string AutorId { get; set; }
        public string Descripcion { get; set; }
        public IFormFile Imagen { get; set; }
        public IFormFile File { get; set; }
        public int Year { get; set; }
        public string TipoId { get; set; }
    }
}
