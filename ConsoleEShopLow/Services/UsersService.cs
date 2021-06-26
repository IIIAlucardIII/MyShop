using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Models;
using ConsoleEShopLow.Repository;

namespace ConsoleEShopLow.Services
{
   public class UsersService : IUserService
    {

        readonly IUserRepository _usersRepository;

        public UsersService(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public bool Registration(string login, string password)
        {
            if (login == null || password == null)
            {
                
                return false;
            }        

            User user = new User { Login = login, Password = password, CurentRole = Role.User };

            _usersRepository.AddUser(user);

            return true;
        }
    }
}
