using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class Carrera : Documento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [BsonElement("Facultad")]
        public string FacultadId { get; set; }
    }
}
