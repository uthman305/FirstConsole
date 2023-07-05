using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public class Customer : BaseEntity
    {
        public string CustomerId;
        public string Pin;
        public double MoneyBalance;
        public double CardBalance;
        public Customer(int id, string customerId, string pin, double moneyBalance, double cardBalance) : base(id)
        {
            CustomerId = customerId;
            Pin = pin;
            MoneyBalance = moneyBalance;
            CardBalance = cardBalance;
        }

    }
}