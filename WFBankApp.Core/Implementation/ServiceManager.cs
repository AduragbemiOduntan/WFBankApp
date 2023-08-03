using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBankApp.Core.Abstraction;
using WFBankApp.Repository.UnitOfWork.Abstractions;

namespace WFBankApp.Core.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private IAuthenticationService _authenticationService;
       /* private IAccountService _accountService;*/
        private ITransactionService _transactionService;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IAuthenticationService AuthenticationService =>
            _authenticationService ?? new AuthenticationService(_unitOfWork);

    /*    public IAccountService AccountService =>
            _accountService ?? new AccountService(_unitOfWork);*/

        public ITransactionService TransactionService =>
            _transactionService ?? new TransactionService(_unitOfWork);
    }
}
