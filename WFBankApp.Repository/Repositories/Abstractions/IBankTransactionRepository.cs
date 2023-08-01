using System.Transactions;
using WFbankApp.Models.Models;

namespace WFBankApp.Repository.Repositories.Abstractions
{
    public interface IBankTransactionRepository 
    {
       /* Task<IEnumerable<BankTransaction>> GetUserDailyTrans(string accountNumber, DateTime date);*/
        Task<IEnumerable<BankTransaction>> GetAllTransByAcctNum(string accountNumber);
        Task<IEnumerable<BankTransaction>> GetAllTransByDate(DateTime date);
    }
}
