using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class Facultad : Documento
    {
        [BsonElement("codigo")]
        public string Codigo { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }

    }
}
