using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Enums;

namespace WFbankApp.Models.Models
{
    public class BankTransaction : AuditableBaseEntity
    {
        public double TransactionAmount { get; set; }
        public string AccountNumber { get; set; }
        public string DestinationAccount { get; set; }
        public string TransactionDescription { get; set; }
        public TransactionType TransactionType { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
     /*   public string TransactionStatus { get; set; }*/

    }
}
