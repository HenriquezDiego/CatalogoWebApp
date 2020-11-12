namespace CatalogoWebApp.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }
    }
}
