using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;

namespace WFBankApp.Repository.Repositories.Abstractions
{
    public interface IAccountRepository
    {
        /*Task<IEnumerable<Account>> GetAcctDeialByAcctNum();*/
        Task<IEnumerable<Account>> GetAllAccounts();
        Task<IEnumerable<Account>> GetAccountsByUserId(int id);

    }
}
