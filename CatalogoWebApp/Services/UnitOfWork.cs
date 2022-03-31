using CatalogoWebApp.Models.NoSQL;
using Microsoft.Extensions.Options;


namespace CatalogoWebApp.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStoreServices<Autor> Autores { get; }
        public IStoreServices<TrabajoDeGraduacion> TrabajosDeGraduacion { get; }
        public IStoreServices<Tipo> Tipos { get; }
        public IStoreServices<Carrera> Carreras { get; }
        public IStoreServices<Facultad> Facultades { get; }

        public UnitOfWork(IOptions<StoreDatabaseSettings> settings)
        {
            Autores = new StoreService<Autor>(settings,"Autores");
            TrabajosDeGraduacion = new StoreService<TrabajoDeGraduacion>(settings,"TrabajosDeGraduacion");
            Tipos = new StoreService<Tipo>(settings,"Tipos");
            Carreras = new StoreService<Carrera>(settings,"Carreras");
            Facultades = new StoreService<Facultad>(settings,"Facultades");
        }
    }
}
