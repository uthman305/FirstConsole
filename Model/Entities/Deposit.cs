using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public class Deposit : BaseEntity
    {

        public double Amount;
        public string CustomerId;

        public Deposit(int id, double amount, string customerId) : base(id)
        {

            Amount = amount;
            CustomerId = customerId;

        }


    }
}