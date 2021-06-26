using System.Collections.Generic;
using System.Linq;
using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;

namespace ConsoleEShopLow.Repository
{
    public class UsersRepository : IUserRepository
    {
        readonly List<User> users = new List<User>();
        int userId = 0;
        public UsersRepository()
        {
            users.Add(new User
            {
                CurentRole = Role.Admin, Login = "Boris", UserId = 1, Password = "123q"
            });
        }
        public void AddUser(User user)
        {
            userId++;
            user.UserId = userId;
            users.Add(user);
        }

        public User GetUser(string login)
        {
            return users.FirstOrDefault(u => u.Login == login);
        }
    }
}
