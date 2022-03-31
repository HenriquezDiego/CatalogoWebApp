using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoWebApp.Models.NoSQL
{
    public class Autor : Documento
    {
        private string _nombres;
        private string _apellidos;
        [BsonElement("codigo")]
        public string Codigo { get; set; }

        [BsonElement("nombres")]
        public string Nombres
        {
            get => _nombres?.Trim();
            set => _nombres = value;
        }

        [BsonElement("apellidos")]
        public string Apellidos
        {
            get => _apellidos?.Trim();
            set => _apellidos = value;
        }
        [BsonElement("nombreCompleto")]
        public string NombreCompleto { get; set; }
        [BsonElement("carreraCodigo")]
        public string CarreraId { get; set; }
        public Carrera Carrera { get; set; }
    }
}
