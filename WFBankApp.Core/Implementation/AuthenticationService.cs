using WFbankApp.Models.Models;
using WFBankApp.Core.Abstraction;
using WFBankApp.Repository.UnitOfWork.Abstractions;
using WFBankApp.Share.Utilities;


namespace WFBankApp.Core.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        /*    private readonly BankDbContext _context;
            private readonly DbSet<User> _dbSet;
    */
        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<(User user, string error)> LoginUser(string email, string password)
        {
            if (email.IsValidEmail())
            {
                User user = await _unitOfWork.UserRepository.GetUserByEmailAsync(email);
                if (user is null || !password.CompareHash(user.PasswordSalt, user.Password))
                {
                    return (null, "Email or Password is incorrect");
                }
                return (user, string.Empty);
            }
            return (null, "Invalid email address");
        }

        public async Task<(bool status, string error)> RegisterUser(string email, string password)
        {
            if (email.IsValidEmail())
            {
                User userExist = await _unitOfWork.UserRepository.GetUserByEmailAsync(email);
                if (userExist is null)
                {
                    var passwordDetails = password.GenerateHash();
                    User user = new User() { Email = email, Password = passwordDetails[0], PasswordSalt = passwordDetails[1] };
                    _unitOfWork.UserRepository.CreateUser(user);
                    await _unitOfWork.SaveAsync();
                    //_unitOfWork.Dispose();
                    return (true, string.Empty);

                }
                else
                {
                    return (false, "User already exist");
                }
            }
            else
            {
                return (false, "Invalid email format");
            }




            /*  public Task<User> Login(string email, string password)
              {
                  return e
              }*/

            /*        public async Task<object> Register(User user)
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
                    }*/
        }
    }
}