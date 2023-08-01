using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;
using WFBankApp.Repository.Data;
using WFBankApp.Repository.Repositories.Abstractions;

namespace WFBankApp.Repository.Repositories.Implementations
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly BankDbContext _dbContext;
        private readonly DbSet<Account> _dbSet;

        public AccountRepository(BankDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Account>();
        }

        public async Task<IEnumerable<Account>> GetAccountsByUserId(int id)
        {
            IEnumerable<Account> accounts = await _dbSet.Where(x => x.UserId == id).ToListAsync();
            return accounts;
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            return await _dbSet.OrderBy(x => x.Id).ToListAsync();
        }

        void CreateAccount(Account account)
        {
            Create(account);
        }
        void UpdateAccount(Account account)
        {
            Update(account);
        }
        void DeleteAccount(Account account)
        {
            Delete(account);
        }
        void DeleteRangeAccount(IEnumerable<Account> accounts)
        {
            DeleteRange(accounts);
        }
    }
}
