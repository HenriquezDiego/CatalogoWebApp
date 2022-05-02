using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class Facultad : Documento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

    }
}
