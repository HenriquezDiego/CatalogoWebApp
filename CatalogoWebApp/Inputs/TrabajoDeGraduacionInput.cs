using CatalogoWebApp.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace CatalogoWebApp.Inputs
{
    public class TrabajoDeGraduacionInput
    {
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public string Descripcion { get; set; }
        public IFormFile Imagen { get; set; }
        public DateTime Fecha { get; set; }
        public TipoId TipoId { get; set; }
    }
}
