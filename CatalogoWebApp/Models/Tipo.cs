namespace CatalogoWebApp.Models
{
    public enum TipoId
    {
        /// <summary>
        /// 1
        /// </summary>
        Pasantia = 1,
        /// <summary>
        /// 2
        /// </summary>
        Proyecto = 2,
        /// <summary>
        /// 3
        /// </summary>
        Tesis = 3,
    }
    public class Tipo
    {
        public TipoId TipoId { get; set; }
        public string Nombre { get; set; }
    }
}
