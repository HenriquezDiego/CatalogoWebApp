namespace CatalogoWebApp.Models
{
    public class Carrera
    {

        public int CarreraId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int FacultadId { get; set; }
        public Facultad Facultad { get; set; }
    }
}