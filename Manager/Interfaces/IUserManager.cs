using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Interfaces
{
    public interface IUserManager
    {
        public User Get(string email);
        public User Login(string email, string password);

    }
}