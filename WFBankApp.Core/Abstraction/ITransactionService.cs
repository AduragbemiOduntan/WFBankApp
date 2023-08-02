using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;
using WFBankApp.Repository.Repositories.Abstractions;

namespace WFBankApp.Core.Abstraction
{
    public interface ITransactionService
    {
        Task<IEnumerable<BankTransaction>> GetAllTransactionByAccountNumber(string acctNum);
        Task<IEnumerable<BankTransaction>> GetAllDailyTransaction(string date);
        Task DeleteTransactionById(int id);
    }
}
