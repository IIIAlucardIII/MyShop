using ConsoleEShopLow.Interfaces;
using System;

namespace ConsoleEShopLow.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        readonly IUserRepository _usersRepository;
        readonly ICurrentUser _currentUser;
        
        public AuthorizationService(IUserRepository userRepository, ICurrentUser currentUser)
        {
            _usersRepository = userRepository;
            _currentUser = currentUser;

        }
        
        public void LogIn(string login, string password)
        {
            var user = _usersRepository.GetUser(login);
            if (user != null)
            {
                if (password == user.Password)
                {
                    _currentUser.SetCurrentUser(user);
                }
                else
                {
                    throw new Exception("");    
                }
            }
            else
            {
                throw new Exception(" ");
            }
        }

        public void LogOut()
        {
            if (_currentUser != null)
            {
                _currentUser.CleanCurrentUser();
            }
        }


    }
}
