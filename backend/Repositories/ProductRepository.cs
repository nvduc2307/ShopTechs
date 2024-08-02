using Databases;
using Entities;
using IRepositories;

namespace Repositories
{
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(MainDbContext dbContext) : base(dbContext)
        {
        }
    }
}