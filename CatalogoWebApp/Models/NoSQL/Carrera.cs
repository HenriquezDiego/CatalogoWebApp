using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class Carrera : Documento
    {
        [BsonElement("codigo")]

        public string Codigo { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("facultad")]
        public string FacultadId { get; set; }
    }
}
