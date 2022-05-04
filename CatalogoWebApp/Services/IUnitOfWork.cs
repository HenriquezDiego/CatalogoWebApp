using System.Collections.Generic;
using System.Threading.Tasks;
using CatalogoWebApp.Models.NoSQL;

namespace CatalogoWebApp.Services
{
    public interface IUnitOfWork
    {
        public IStoreServices<Autor> Autores { get; }
        public IStoreServices<TrabajoDeGraduacion> TrabajosDeGraduacion { get; }
        public IStoreServices<Tipo> Tipos { get; }
        public IStoreServices<Carrera> Carreras { get; }
        public IStoreServices<Facultad> Facultades { get; }
        Task<List<TrabajoDeGraduacion>> GetTrabajosDeGraduacionIncludes();
        Task<TrabajoDeGraduacion> GetTrabajoDeGraduacionIncludes(string id);
    }
}
