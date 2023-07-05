using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;

namespace CardConsole.Manager.Implementations
{
    public class PurchaseManager : IPurchaseManager
    {
        public static List<Purchase> PurchaseDb = new List<Purchase>();

        IAgentManager agentManager = new AgentManager();
        ICustomerManager customerManager = new CustomerManager();
        IDirectorManager directorManager = new DirectorManager();
        ICompanyManager companyManager = new CompanyManager();

        public Purchase AdminMake(string agentId, string companyName, string directorId, double amount, string pin)
        {
            var director = directorManager.Get(directorId);
            var company = companyManager.Get(companyName);
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
                        if (agent.AgentMoneyBalance > amount && company.CompanyCardBalance > amount)
                        {
                            agent.AgentCardBalance += amount;
                            agent.AgentMoneyBalance -= amount;
                            company.CompanyMoneyBalance += amount;
                            company.CompanyCardBalance -= amount;
                            Purchase purchase = new Purchase(PurchaseDb.Count + 1, amount, agentId);
                            System.Console.WriteLine("succesful");
                            PurchaseDb.Add(purchase);
                            return purchase;
                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient found");
                            return null;
                        }

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

        public Purchase Make(string customerId, string agentId, double amount, string pin)
        {
            var customer = customerManager.Get(customerId);
            var agent = agentManager.Get(agentId);
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
                        if (customer.MoneyBalance > amount && agent.AgentCardBalance > amount)
                        {
                            customer.CardBalance += amount;
                            agent.AgentCardBalance -= amount;
                            customer.MoneyBalance -= amount;
                            agent.AgentMoneyBalance += amount;
                            Purchase purchase = new Purchase(PurchaseDb.Count + 1, amount, customerId);
                            System.Console.WriteLine("succesful");
                            PurchaseDb.Add(purchase);
                            return purchase;
                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient found");
                            return null;
                        }

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