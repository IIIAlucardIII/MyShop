using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;

namespace ConsoleEShopLow.Services
{
    public class CurrentUserService : ICurrentUser
    {
        User user;

        

        public User GetCurrentUser()
        {
            return user;
        }
        public void SetCurrentUser(User user)
        {
            this.user = user;
        }
        public void CleanCurrentUser()
        {
            user = null;
        }

    }
}
