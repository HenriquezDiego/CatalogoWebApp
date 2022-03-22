namespace CatalogoWebApp.Models.NoSQL
{
    public class Autor : Documento
    {
        private string _nombres;
        private string _apellidos;
        public int AutorId { get; set; }
        public string Codigo { get; set; }

        public string Nombres
        {
            get => _nombres?.Trim();
            set => _nombres = value;
        }

        public string Apellidos
        {
            get => _apellidos?.Trim();
            set => _apellidos = value;
        }

        public string NombreCompleto => _nombres + " " + _apellidos;
        public string CarreraId { get; set; }
    }
}
