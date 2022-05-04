using System;
using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class TrabajoDeGraduacion : Documento
    {
        public string Titulo { get; set; }
        public string AutorId { get; set; }
        public Autor Autor { get; set; }
        public string Descripcion { get; set; }
        public string PathImagen { get; set; }
        public string PathFile { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoId { get; set; }
        public Tipo Tipo { get; set; }
    }
}
