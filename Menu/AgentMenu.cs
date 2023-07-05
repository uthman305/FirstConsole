using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Implementations;
using CardConsole.Manager.Interfaces;

namespace CardConsole.Menu
{
    public class AgentMenu
    {
        IDepositManager depositManager = new DepositManager();
        IPurchaseManager purchaseManager = new PurchaseManager();
        IAgentManager agentManager = new AgentManager();
        ICustomerManager customerManager = new CustomerManager();



        public void AgentMain()
        {
            System.Console.WriteLine("enter 1 to deposit Card");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                DepositMenu();
            }

            else
            {
                System.Console.WriteLine("wrong input");
                AgentMain();
            }
        }

        public void DepositMenu()
        {
            Console.Write("enter your account number: ");
            string customerId = Console.ReadLine();
            Console.Write("enter the amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("enter your pin: ");
            string pin = (Console.ReadLine());

            var deposit = depositManager.AdminMake(customerId, amount, pin);
            if (deposit == null)
            {
                Console.WriteLine("transaction failed");
            }
            else
            {
                var agent = agentManager.Get(deposit.CustomerId);
                Console.WriteLine($"transaction succesful, your new balance is {agent.AgentCardBalance}");

                Console.WriteLine(" Do you want to continue if yes press 1 if no press any number");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Main();
                }
            }

        }



    }
}