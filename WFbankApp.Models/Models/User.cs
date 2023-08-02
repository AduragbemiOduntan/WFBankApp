using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFbankApp.Models.Models
{
    public class User : AuditableBaseEntity
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
