using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Implementations
{
    public class AgentManager : IAgentManager
    {
        public static List<Agent> AgentDb = new List<Agent>();
        public Agent Get(string agentId)
        {
            foreach (var agent in AgentDb)
            {
                if (agent.AgentId == agentId)
                {
                    return agent;
                }
            }
            return null;
        }

        public Agent Get(int id)
        {
            foreach (var agent in AgentDb)
            {
                if (agent.Id == id)
                {
                    return agent;
                }
            }
            return null;
        }

        public Agent Open(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender, string pin)
        {
            User user = new User(UserManager.UserDb.Count + 1, firstName, lastName, email, password, phoneNumber, dob, gender, "Agent");
            UserManager.UserDb.Add(user);



            Agent agent = new Agent(AgentDb.Count + 1, GenerateAgentId(phoneNumber), pin, 0, 0);
            AgentDb.Add(agent);
            return agent;
        }
        public string GenerateAgentId(string phoneNumber)
        {
            string walletId = "";
            walletId = phoneNumber.Substring(1, 10);
            return walletId;
        }

    }
}