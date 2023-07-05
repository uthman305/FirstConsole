using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Interfaces
{
    public interface IAgentManager
    {
        public Agent Open(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Model.Enum.Gender gender, string pin);
        public Agent Get(string AgentId);
        public Agent Get(int id);
    }
}