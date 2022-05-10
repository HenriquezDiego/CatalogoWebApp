using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoWebApp.DataAccess;
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

        public async Task<List<TrabajoDeGraduacion>> GetTrabajosDeGraduacionIncludes()
        {
            var trabajos = await TrabajosDeGraduacion.GetAllAsync();
            var autores = await Autores.GetAllAsync();
            var carreras = await Carreras.GetAllAsync();
            var tipos = await Tipos.GetAllAsync();

            var query = from t in trabajos
            join tp in tipos on t.TipoId equals tp.Id 
            join a in autores on t.AutorId equals a.Id
            join c in carreras on a.CarreraCodigo equals c.Codigo 
            select new TrabajoDeGraduacion
            {
                Id = t.Id,
                Titulo = t.Titulo,
                Descripcion = t.Descripcion,
                Fecha = t.Fecha,
                PathFile = t.PathFile,
                PathImagen = t.PathImagen,
                TipoId = t.TipoId,
                Tipo = tp,
                AutorId = a.Id,
                Autor = a
            };

            foreach (var row in query)
            {
                row.Autor.Carrera = carreras.FirstOrDefault(c => c.Codigo == row.Autor.CarreraCodigo);
            }

            return query.ToList();
        }

        public async Task<TrabajoDeGraduacion> GetTrabajoDeGraduacionIncludes(string id)
        {
            var trabajo = await TrabajosDeGraduacion.GetAsync(id);
            if (trabajo == null) return null;
            var autore = await Autores.GetAsync(trabajo.AutorId);
            var carreras = await Carreras.GetAllAsync();
            var facultades = await Facultades.GetAllAsync();
            var tipo = await Tipos.GetAsync(trabajo.TipoId);
            trabajo.Tipo = tipo;
            autore.Carrera = carreras.FirstOrDefault(c => c.Codigo == autore.CarreraCodigo);
            autore.Carrera.Facultad = facultades.FirstOrDefault(f => f.Codigo == autore.Carrera.FacultadId);
            trabajo.Autor = autore;
            return trabajo;
        }
    }
}
