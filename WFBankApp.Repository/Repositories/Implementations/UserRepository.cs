using Microsoft.EntityFrameworkCore;
using WFbankApp.Models.Models;
using WFBankApp.Repository.Data;
using WFBankApp.Repository.Repositories.Abstractions;

namespace WFBankApp.Repository.Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>,  IUserRepository
    {
        private readonly BankDbContext _dbContext;
        private readonly DbSet<User> _dbSet;

        public UserRepository(BankDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<User>();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _dbSet.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _dbSet.FindAsync(email);
        }

        public User CreateUser(User user)
        {
            Create(user);
            return user;
        }
        public void UpdateUser(User user)
        {
            Update(user);
        }
        public void DeleteUser(User user)
        {
            Delete(user);
        }
        public void DeleteRangeUser(IEnumerable<User> user)
        {
            DeleteRange(user);
        }
    }
}
