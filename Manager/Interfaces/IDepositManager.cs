using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Interfaces
{
    public interface IDepositManager
    {
        public Deposit Make(string customerId, double amount, string pin);
        public Deposit AdminMake(string agentId, double amount, string pin);
        public Deposit CompanyMake(string direcorId, string companyName, double amount, string pin);

    }
}