using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class Documento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
