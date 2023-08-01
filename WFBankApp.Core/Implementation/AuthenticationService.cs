using WFbankApp.Models.Models;
using WFBankApp.Repository.UnitOfWork.Abstractions;
using WFBankApp.Share.Utilities;


namespace WFBankApp.Core.Implementation
{
    public class AuthenticationService 
    {
        private readonly IUnitOfWork _unitOfWork;
        /*    private readonly BankDbContext _context;
            private readonly DbSet<User> _dbSet;
    */
        /*     public AuthenticationService(IUnitOfWork unitOfWork)
             {
                 _unitOfWork = unitOfWork;
             }*/

        /*  public Task<User> Login(string email, string password)
          {
              return e
          }*/

        public async Task<object> Register(User user)
        {
            if((!(user.Email.IsValidEmail()) || (user.Email != null )))
            {
                return "Invalid email";
            }
            var emailExist = user.Email.IsEmailAlreadyRegistered();
            if (emailExist)
            {
                return "Email already exist";
            }
            User regUser =  _unitOfWork.User.CreateUser(user);
            var hashedPW = regUser.Password.GenerateHash();
            return "Registration Successful!";
        }
    }
}
