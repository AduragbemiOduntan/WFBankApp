using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;

namespace WFBankApp.Core.Abstraction
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAccountsByType();
        Task<IEnumerable<Account>> GetAllAccounts(int id);
        /*  Task<IEnumerable<Account>> GetAccountsByBalance();*/
        Task<IEnumerable<Account>> GetAllAccount();
    }
}
