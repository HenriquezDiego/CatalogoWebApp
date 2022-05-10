using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogoWebApp.DataAccess
{
    public interface IStoreServices<T>
    {
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(string id);
        Task CreateAsync(T value);
        Task UpdateAsync(string id, T value);
        Task RemoveAsync(string id);
    }
}
