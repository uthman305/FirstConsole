using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Implementations
{
    public class DepositManager : IDepositManager
    {
        public static List<Deposit> DepositDb = new List<Deposit>();


        ICustomerManager customerManager = new CustomerManager();
        IDirectorManager directorManager = new DirectorManager();
        ICompanyManager companyManager = new CompanyManager();
        IAgentManager agentManager = new AgentManager();
        IUserManager userManager = new UserManager();

        public Deposit AdminMake(string agentId, double amount, string pin)
        {
            var agent = agentManager.Get(agentId);

            if (agent == null)
            {
                System.Console.WriteLine("account not found");
                return null;
            }
            else
            {
                if (agent.Pin == pin)
                {
                    if (amount > 0)
                    {
                        agent.AgentMoneyBalance += amount;
                        Deposit deposit = new Deposit(DepositDb.Count + 1, amount, agentId);
                        System.Console.WriteLine("succesful");
                        DepositDb.Add(deposit);
                        return deposit;
                    }
                    else

                    {
                        System.Console.WriteLine("amount must be greater than zero");
                        return null;
                    }
                }
                else
                {
                    System.Console.WriteLine("invalid pin");
                    return null;
                }
            }
        }

        public Deposit CompanyMake(string direcorId,string companyName, double amount, string pin)
        {
             var director = directorManager.Get(direcorId);
             var company = companyManager.Get(companyName);

            if (director == null)
            {
                System.Console.WriteLine("account not found");
                return null;
            }
            else
            {
                if (director.Pin == pin)
                {
                    if (amount > 0)
                    {
                        company.CompanyCardBalance += amount;
                        Deposit deposit = new Deposit(DepositDb.Count + 1, amount, direcorId);
                        System.Console.WriteLine("succesful");
                        DepositDb.Add(deposit);
                        return deposit;
                    }
                    else

                    {
                        System.Console.WriteLine("amount must be greater than zero");
                        return null;
                    }
                }
                else
                {
                    System.Console.WriteLine("invalid pin");
                    return null;
                }
            }
        }

        public Deposit Make(string customerId, double amount, string pin)
        {
            var customer = customerManager.Get(customerId);
            if (customer == null)
            {
                System.Console.WriteLine("account not found");
                return null;
            }
            else
            {
                if (customer.Pin == pin)
                {
                    if (amount > 0)
                    {
                        customer.MoneyBalance += amount;
                        Deposit deposit = new Deposit(DepositDb.Count + 1, amount, customerId);
                        System.Console.WriteLine("succesful");
                        DepositDb.Add(deposit);
                        return deposit;
                    }
                    else

                    {
                        System.Console.WriteLine("amount must be greater than zero");
                        return null;
                    }
                }
                else
                {
                    System.Console.WriteLine("invalid pin");
                    return null;
                }
            }
        }
    }
}