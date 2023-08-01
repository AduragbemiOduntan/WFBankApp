using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBankApp.Repository.Repositories.Abstractions;
using WFBankApp.Repository.Repositories.Implementations;

namespace WFBankApp.Repository.UnitOfWork.Abstractions
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IAccountRepository Account { get; }
        IBankTransactionRepository BankTransaction { get; }
        Task SaveAsync();
        void Dispose();
    }
}
