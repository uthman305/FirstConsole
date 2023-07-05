using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Implementations;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;

namespace CardConsole.Menu
{
    public class CustomerMenu
    {
        IDepositManager depositManager = new DepositManager();
        IPurchaseManager purchaseManager = new PurchaseManager();
        ICustomerManager customerManager = new CustomerManager();
        IAgentManager agentManager = new AgentManager();

        public void CustomerMain()
        {
            System.Console.WriteLine("enter 1 to deposit \n enter 2 to purchase card");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                DepositMenu();
            }
            else if (opt == 2)
            {
                PurchaseMenu();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                CustomerMain();
            }
        }

        public void DepositMenu()
        {
            Console.Write("enter your account number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("enter the amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("enter your pin: ");
            string pin = Console.ReadLine();

            var deposit = depositManager.Make(accountNumber, amount, pin);
            if (deposit == null)
            {
                Console.WriteLine("transaction failed");
            }
            else
            {
                var customer = customerManager.Get(deposit.CustomerId);
                Console.WriteLine($"transaction succesful, your new balance is {customer.MoneyBalance}");

                Console.WriteLine(" Do you want to continue if yes press 1 if no press any number");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    CustomerMain();
                }
            }

        }

        public void PurchaseMenu()
        {
            Console.Write("enter your account number: ");
            string customerId = Console.ReadLine();
            Console.Write("enter your buyer account number: ");
            string agentId = Console.ReadLine();
            Console.Write("enter the amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("enter your pin: ");
            string pin = (Console.ReadLine());



            var purchase = purchaseManager.Make(customerId, agentId, amount, pin);
            var wallets = agentManager.Get(agentId);
            Console.WriteLine($"The available card for purchase is {wallets.AgentCardBalance}");
            if (purchase == null)
            {
                Console.WriteLine("transaction failed");
            }
            else
            {
                var customer = customerManager.Get(purchase.CustomerId);
                Console.WriteLine($"transaction succesful, your new balance is {customer.MoneyBalance} and {customer.CardBalance}");
            }

        }

    }
}