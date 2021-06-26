using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEShopLow.Models;

namespace ConsoleEShopLow.Interfaces
{
    public interface ICurrentUser
    {
        User GetCurrentUser();

        void SetCurrentUser(User user);

        void CleanCurrentUser();
      
    }
}
