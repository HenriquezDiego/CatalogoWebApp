namespace CatalogoWebApp.Models.NoSQL
{
    public class Carrera : Documento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string FacultadId { get; set; }
    }
}
