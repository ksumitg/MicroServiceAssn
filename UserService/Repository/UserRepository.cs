using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.DbContexts;
using UserService.Models;

namespace UserService.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly UserContext _dbContext;
        public UserRepository(UserContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return _dbContext.Users.Find(userId);
        }
    }
}
