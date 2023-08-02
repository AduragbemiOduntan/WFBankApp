using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WFbankApp.Models.Models;
using WFBankApp.Core.Abstraction;
using WFBankApp.Repository.UnitOfWork.Abstractions;

namespace WFBankApp.Core.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteTransactionById(int id)
        {
           BankTransaction transaction = await _unitOfWork.BankTransactionRepository.GetTransactionById(id);
           _unitOfWork.BankTransactionRepository.Delete(transaction);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();

        }

        public async Task<IEnumerable<BankTransaction>> GetAllDailyTransaction(string date)
        {
            bool IsDate = DateOnly.TryParse(date, out DateOnly dateValue);
            if(!IsDate)
            {
                return null;
            }
            IEnumerable<BankTransaction> transactions = await _unitOfWork.BankTransactionRepository
                .GetAllTransByDate(dateValue);
            return transactions;

        }

        public async Task<IEnumerable<BankTransaction>> GetAllTransactionByAccountNumber(string acctNum)
        {
            if(acctNum == null)
            {
                return null;
            }
            IEnumerable<BankTransaction> transactions = await _unitOfWork.BankTransactionRepository
                .GetAllTransByAcctNum(acctNum);
            if(transactions.IsNullOrEmpty())
            {
                return null;
            }
            return transactions;
        }
    }
}
