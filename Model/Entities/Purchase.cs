using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public class Purchase : BaseEntity
    {
        public double Amount;
        public string CustomerId;

        public Purchase(int id, double amount, string customerId) : base(id)
        {

            Amount = amount;
            CustomerId = customerId;

        }

    }
}