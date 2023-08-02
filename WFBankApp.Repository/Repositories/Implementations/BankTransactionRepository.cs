using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WFbankApp.Models.Models;
using WFBankApp.Repository.Data;
using WFBankApp.Repository.Repositories.Abstractions;

namespace WFBankApp.Repository.Repositories.Implementations
{
    public class BankTransactionRepository : GenericRepository<BankTransaction>, IBankTransactionRepository
    {
        private readonly BankDbContext _dbContext;
        private readonly DbSet<BankTransaction> _dbSet;

        public BankTransactionRepository(BankDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<BankTransaction>();
        }

        public async Task<IEnumerable<BankTransaction>> GetAllTransByAcctNum(string accountNumber)
        {
            IEnumerable<BankTransaction> transactions = await _dbSet.Where(x => x.AccountNumber == accountNumber).ToListAsync();
            return transactions;
        }

        public async Task<IEnumerable<BankTransaction>> GetAllTransByDate(DateOnly date)
        {
            IEnumerable<BankTransaction> transactions = await _dbSet.Where(x => DateOnly.Parse(x.Datecreated.Date.ToString()) == date).ToListAsync();
            return transactions;
        }

        public async Task<IEnumerable<BankTransaction>> GetAllTransaction()
        {
            IEnumerable<BankTransaction> transactions =  _dbSet.OrderBy(x => x.Id).ToList();
            return transactions;
        }

        public async Task<BankTransaction> GetTransactionById(int id)
        {
            BankTransaction transaction = _dbSet.Find(id);
            return transaction;
        }

  /*      public async Task<IEnumerable<BankTransaction>> GetUserDailyTrans(string accountNumber, DateTime date)
        {
            IEnumerable<BankTransaction> transactions = await _dbSet.Where(x => x.AccountNumber == accountNumber && x.Datecreated == date).ToListAsync();
            return transactions;
        }*/
    }
}
