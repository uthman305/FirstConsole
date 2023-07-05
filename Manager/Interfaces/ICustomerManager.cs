using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Interfaces
{
    public interface ICustomerManager
    {
        public Customer Open(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender, string pin);
        public Customer Get(string CustomerId);
        public Customer Get(int id);
    }
}