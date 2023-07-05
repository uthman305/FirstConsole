using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Implementations
{
    public class DirectorManager : IDirectorManager
    {
        public static List<Director> DirectorDb = new List<Director>();

        public Director Create(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender, string companyName, string pin)
        {
            User user = new User(UserManager.UserDb.Count + 1, firstName, lastName, email, password, phoneNumber, dob, gender, "Manager");
            UserManager.UserDb.Add(user);

            Company company = new Company(CompanyManager.CompanyDb.Count + 1, companyName, 0, 0);
            CompanyManager.CompanyDb.Add(company);

            Director director = new Director(DirectorManager.DirectorDb.Count + 1, GenerateDirectorId(phoneNumber), pin);
            DirectorManager.DirectorDb.Add(director);
            return director;

        }

        public Director Get(string directorId)
        {
            foreach (var director in DirectorDb)
            {
                if (director.DirectorId == directorId)
                {
                    return director;
                }
            }
            return null;
        }

        public Director Get(int id)
        {
            foreach (var director in DirectorDb)
            {
                if (director.Id == id)
                {
                    return director;
                }
            }
            return null;
        }
        public string GenerateDirectorId(string phoneNumber)
        {
            string walletId = "";
            walletId = phoneNumber.Substring(1, 10);
            return walletId;
        }

    }
}