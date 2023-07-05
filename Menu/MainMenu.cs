using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Implementations;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Enum;

namespace CardConsole.Menu
{
    public class MainMenu
    {
        ICustomerManager customerManager = new CustomerManager();
        IUserManager userManager = new UserManager();
        CustomerMenu customerMenu = new CustomerMenu();
        AgentMenu agentMenu = new AgentMenu();
        SuperAdminMenu superAdminMenu = new SuperAdminMenu();

        public void Main()
        {
            Console.WriteLine("welcome to SalTech\nEnter 1 to Register\nEnter 2 to login");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                AccountForm();
            }
            else if (option == 2)
            {
                LoginForm();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                Main();
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

            var customer = customerManager.Open(fName, lName, email, password, phoneNumber, dob, (Gender)gender, pin);
            if (customer == null)
            {
                System.Console.WriteLine("not succesful");
            }
            else
            {
                System.Console.WriteLine($"congratulations  your account number is {customer.CustomerId}");
            }

            Main();


        }

        public void LoginForm()
        {
            Console.Write("enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();

            var user = userManager.Login(email, password);
            if (user == null)
            {
                Console.WriteLine("wrong cridentials");
                LoginForm();
            }
            else
            {

                if (user.Role == "Customer")
                {
                    customerMenu.CustomerMain();
                }
                else if (user.Role == "Agent")
                {
                    agentMenu.AgentMain();
                }
                else if (user.Role == "Manager")
                {
                    agentMenu.AgentMain();
                }
                else if (user.Role == "SuperAdmin")
                {
                    superAdminMenu.SuperMain();
                }

            }

        }
    }
}