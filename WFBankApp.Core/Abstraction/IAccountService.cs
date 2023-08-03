/*using System;
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
        Task<IEnumerable<Account>> GetAllUserAccounts(int id);
        *//*  Task<IEnumerable<Account>> GetAccountsByBalance();*//*
        Task<IEnumerable<Account>> GetAllAccount();


        Task<Account> CreateAccount(int userId, string firstName, string lastName, string email, int transactionPin, string PhoneNumber, string AccountType);
        Task DeleteAccount(string accountNumber);
        Task<Account> GetAccountByNumber(string accountNumber);
        Task<(bool status, string error)> Deposit(string accountNumber, decimal amount);
        Task<(bool status, string error)> Withdrawal(string accountNumber, decimal amount);
        Task<(bool status, string error)> Transfer(string accountNumber, string creditAccountNumber, decimal amount, string description, string receiverName);
    }
}

*/