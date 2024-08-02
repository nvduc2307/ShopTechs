using Databases;
using IRepositories;

namespace UnitOfWorks
{
    public interface IUnitOfWork {
        public MainDbContext MainDbContext{ get; }
        public IProductRepository IProductRepository{ get; }
    }
}