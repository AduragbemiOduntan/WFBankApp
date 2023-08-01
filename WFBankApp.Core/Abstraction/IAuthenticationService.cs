using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;

namespace WFBankApp.Core.Abstraction
{
    public interface IAuthenticationService
    {
        /* Task<User> Login(string email, string password);*/
        Task<object> Register(User user);
    }
}
