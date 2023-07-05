using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Interfaces
{
    public interface IPurchaseManager
    {
        public Purchase Make(string customerId, string agentId, double amount, string pin);

        public Purchase AdminMake(string agentId, string companyName, string directorId, double amount, string pin);

    }
}