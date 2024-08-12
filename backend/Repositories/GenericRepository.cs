using Databases;
using IRepositories;

namespace Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public MainDbContext DbContext;
        private async Task<List<T>> GetAllData() {
            return DbContext.Set<T>().ToList();
        }
        public GenericRepository(MainDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task<int> Create(T entity)
        {
            DbContext.Set<T>().Add(entity);
            return DbContext.SaveChanges();
        }

        public async Task<int> Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            return DbContext.SaveChanges();
        }

        public async Task<List<T>> FetchData()
        {
            return await GetAllData();
        }

        public async Task<int> Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
            return DbContext.SaveChanges();
        }
    }
}