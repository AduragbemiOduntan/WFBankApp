using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Enums;

namespace WFbankApp.Models.Models
{
    public class Account : AuditableBaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string PhoneNumber { get; set; }
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; }
        [Column(TypeName = "money")]
        public decimal Balance { get; set; } = 0;
        public ICollection<BankTransaction> transactions { get; set; }
    }
}
