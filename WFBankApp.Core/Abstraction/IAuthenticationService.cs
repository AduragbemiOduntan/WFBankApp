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
        Task<(User user, string error)> LoginUser(string email, string password);
        Task<(bool status, string error)> RegisterUser(string email, string password);

        /* Task<User> Login(string email, string password);*/
        /*Task<object> Register(User user);*/
    }
}
