using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;

namespace WFBankApp.Repository.Repositories.Abstractions
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserByEmailAsync(string email);
        User CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        void DeleteRangeUser(IEnumerable<User> user);
    }
}
