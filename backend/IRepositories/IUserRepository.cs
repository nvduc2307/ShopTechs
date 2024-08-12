using Entities;

namespace IRepositories
{
    public interface IUserRepository : IGenericRepository<UserEntity> {
        public Task<UserEntity> Login(UserLogin userInfoLogin);
    }   
}