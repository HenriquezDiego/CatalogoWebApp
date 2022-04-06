using System;
using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class TrabajoDeGraduacion : Documento
    {
        [BsonElement("titulo")]
        public string Titulo { get; set; }
        [BsonElement("autorId")]
        public string AutorId { get; set; }
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }
        [BsonElement("pathImagen")]
        public string PathImagen { get; set; }
        [BsonElement("pathFile")]
        public string PathFile { get; set; }
        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }
        [BsonElement("Tipo")]
        public string TipoId { get; set; }
    }
}
