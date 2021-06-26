using ConsoleEShopLow.Models;

namespace ConsoleEShopLow.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUser(string login);
    }
}
