using Databases;
using IRepositories;

namespace UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public MainDbContext MainDbContext{ get; }
        public IProductRepository IProductRepository { get; }

        public UnitOfWork(MainDbContext mainDbContext,
        IProductRepository iProductRepository)
        {
            MainDbContext = mainDbContext;
            IProductRepository = iProductRepository;
        }
    }
}