using Databases;
using Entities;
using IRepositories;

namespace Repositories
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(MainDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<UserEntity> Login(UserLogin userInfoLogin)
        {
            try
            {
                var users = DbContext.users.ToList();
                if (userInfoLogin == null) return null;
                if (userInfoLogin.UserName == null) return null;
                if (string.IsNullOrEmpty(userInfoLogin.PassWord)) return null;
                var user = users.FirstOrDefault(x=>x.Name == userInfoLogin.UserName);
                if (user == null) return null;
                if (user.PassWord != userInfoLogin.PassWord) return null;
                return user;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}