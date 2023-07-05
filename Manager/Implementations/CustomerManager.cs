using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Implementations
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> CustomerDb = new List<Customer>();
        public Customer Get(string customerId)
        {
            foreach (var customer in CustomerDb)
            {
                if (customer.CustomerId == customerId)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer Get(int id)
        {
            foreach (var customer in CustomerDb)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer Open(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender, string pin)
        {
            User user = new User(UserManager.UserDb.Count + 1, firstName, lastName, email, password, phoneNumber, dob, gender, "Customer");
            UserManager.UserDb.Add(user);



            Customer customer = new Customer(CustomerDb.Count + 1, GenerateCustomerId(phoneNumber), pin, 0, 0);
            CustomerDb.Add(customer);
            return customer;
        }

        public string GenerateCustomerId(string phoneNumber)
        {
            string walletId = "";
            walletId = phoneNumber.Substring(1, 10);
            return walletId;
        }
    }
}