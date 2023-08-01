using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Enums;

namespace WFBankApp.Share.DTOs.ReadDto
{
    public class BankTransactionReadDto
    {
        public double TransactionAmount { get; set; }
        public string AccountNumber { get; set; }
        public string DestinationAccount { get; set; }
        public string TransactionDescription { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Balance { get; set; }
    }
}
