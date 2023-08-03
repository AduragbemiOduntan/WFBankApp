using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBankApp.Core.Abstraction
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
    /*    IAccountService AccountService { get; }*/
        ITransactionService TransactionService { get; }
    }
}
