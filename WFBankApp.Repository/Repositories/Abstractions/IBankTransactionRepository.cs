using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;

namespace WFBankApp.Repository.Repositories.Abstractions
{
    public interface IBankTransactionRepository : IGenericRepository<BankTransaction>
    {
       /* Task<IEnumerable<BankTransaction>> GetUserDailyTrans(string accountNumber, DateTime date);*/
        Task<BankTransaction> GetTransactionById(int id);
        Task<IEnumerable<BankTransaction>> GetAllTransByAcctNum(string accountNumber);
        Task<IEnumerable<BankTransaction>> GetAllTransByDate(DateOnly date);
    }
}
