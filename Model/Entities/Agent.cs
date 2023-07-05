using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public class Agent : BaseEntity
    {
        public string AgentId;
        public string Pin;
        public double AgentMoneyBalance;
        public double AgentCardBalance;
        public Agent(int id, string agentId, string pin, double agentMoneyBalance, double agentCardBalance) : base(id)
        {
            AgentId = agentId;
            Pin = pin;
            AgentMoneyBalance = agentMoneyBalance;
            AgentCardBalance = agentCardBalance;
        }
    }
}