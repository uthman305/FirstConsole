using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Implementations;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Enum;

namespace CardConsole.Menu
{
    public class SuperAdminMenu
    {
        IDepositManager depositManager = new DepositManager();
        IPurchaseManager purchaseManager = new PurchaseManager();
        ICustomerManager customerManager = new CustomerManager();
        ICompanyManager companyManager = new CompanyManager();
        IDirectorManager directorManager = new DirectorManager();
        IAgentManager agentManager = new AgentManager();

        public void SuperMain()
        {
            Console.WriteLine("welcome to SalTech\nEnter 1 to Register an agent \nEnter 2 to go to Main menu");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                AccountForm();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                SuperMain();
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
            Console.Write("enter your company name: ");
            string companyName = Console.ReadLine();

            var director = directorManager.Create(fName, lName, email, password, phoneNumber, dob, (Gender)gender, pin, companyName);
            if (director == null)
            {
                System.Console.WriteLine("not succesful");
            }
            else
            {
                System.Console.WriteLine($"congratulations  your account number is {director.DirectorId}");
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