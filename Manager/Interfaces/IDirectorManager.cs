using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Interfaces
{
    public interface IDirectorManager
    {
        Director Get(string DirectorId);
        Director Get(int id);

        Director Create(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender, string companyName, string pin);

    }
}