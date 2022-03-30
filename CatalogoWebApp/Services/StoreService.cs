
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoWebApp.Models;
using CatalogoWebApp.Models.NoSQL;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CatalogoWebApp.Services
{
    public class StoreService<T> : IStoreServices<T> where T : Documento
    {
        private readonly IMongoCollection<T> _collection;
        public StoreService(IOptions<StoreDatabaseSettings> settings, string collection)
        {
            var mongoClient = new MongoClient(
                settings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                settings.Value.DatabaseName);

            _collection = mongoDatabase.GetCollection<T>(collection);
            
        }
        public async Task<List<T>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public List<T> GetAll() => _collection.Find(_ => true).ToList();

        public async Task<T> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(T newBook) =>
            await _collection.InsertOneAsync(newBook);

        public async Task UpdateAsync(string id, T updatedBook) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}
