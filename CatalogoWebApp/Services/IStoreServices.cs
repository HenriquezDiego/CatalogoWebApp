using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogoWebApp.Services
{
    public interface IStoreServices<T>
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(string id);
        Task CreateAsync(T value);
        Task UpdateAsync(string id, T value);
        Task RemoveAsync(string id);
    }
}
