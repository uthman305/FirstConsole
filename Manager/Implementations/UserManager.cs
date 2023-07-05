using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Implementations
{
    public class UserManager : IUserManager
    {
        public static List<User> UserDb = new List<User>()
        {
 new User(1,"Uthman", "Salman","sal@gmail.com","uth","07034649670", DateTime.Parse("1960-10-01"), Model.Enum.Gender.Male,"SuperAdmin")
        };
        public User Get(string email)
        {
            foreach (var user in UserDb)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        public User Login(string email, string password)
        {
            foreach (var user in UserDb)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}