using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Implementations;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Enum;

namespace CardConsole.Menu
{
    public class ManagerMenu
    {
        IDepositManager depositManager = new DepositManager();
        IPurchaseManager purchaseManager = new PurchaseManager();
        ICustomerManager customerManager = new CustomerManager();
        ICompanyManager companyManager = new CompanyManager();
        IDirectorManager directorManager = new DirectorManager();
        IAgentManager agentManager = new AgentManager();

        public void ManagerMain()
        {
            Console.WriteLine("Enter 1 to Register an agent \nEnter 2 to deposit \nEnter 3 to go back to main menu");
            int option = int.Parse(Console.ReadLine());
             if (option == 1)
            {
                AccountForm();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                // SuperMain();
            }
        }
         public void AccountForm()
        {
            Console.Write("enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();
            Console.Write("enter your phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("enter your date of birth: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("enter 1 for male and 2 for female: ");
            int gender = int.Parse(Console.ReadLine());
            Console.Write("enter your pin: ");
            string pin = Console.ReadLine();

            var agent = agentManager.Open(fName, lName, email, password, phoneNumber, dob, (Gender)gender, pin);
            if (agent == null)
            {
                System.Console.WriteLine("not succesful");
            }
            else
            {
                System.Console.WriteLine($"congratulations  your account number is {agent.AgentId}");
                Console.WriteLine(" Do you want to continue if yes press 1 if no press any number");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Main();
                }
            }


        }
         public void DepositMenu()
        {
            Console.Write("enter your account number: ");
            string directorId = Console.ReadLine();
            Console.Write("enter the amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("enter your pin: ");
            string pin = (Console.ReadLine());
            Console.Write("enter your company name: ");
            string companyName = (Console.ReadLine());

            var deposit = depositManager.CompanyMake(directorId,companyName, amount, pin);
            if (deposit == null)
            {
                Console.WriteLine("transaction failed");
            }
            else
            {
                var director = directorManager.Get(deposit.CustomerId);
                var company = companyManager.Get(companyName);
                Console.WriteLine($"transaction succesful, your new balance is {company.CompanyCardBalance}");

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

