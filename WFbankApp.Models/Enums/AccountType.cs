using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFbankApp.Models.Enums
{
    public enum AccountType
    {
        [Description("Current Account")]
        CurrentAccount = 1,
        [Description("Savings Account")]
        SavingsAccount
    }
}
