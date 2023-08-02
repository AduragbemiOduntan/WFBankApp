using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBankApp.Repository.Data;
using WFBankApp.Repository.Repositories.Abstractions;
using WFBankApp.Repository.Repositories.Implementations;
using WFBankApp.Repository.UnitOfWork.Abstractions;

namespace WFBankApp.Repository.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository _userRepository;
        private IAccountRepository _accountRepository;
        private IBankTransactionRepository _bankTransactionRepository;
        private readonly BankDbContext _dbContext;

        public UnitOfWork(BankDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_dbContext);
        public IAccountRepository AccountRepository => _accountRepository ??= new AccountRepository(_dbContext);
        public IBankTransactionRepository BankTransactionRepository => _bankTransactionRepository ??= new BankTransactionRepository(_dbContext);

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
