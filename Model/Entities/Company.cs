using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;

namespace CardConsole.Model.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName;
        public double CompanyMoneyBalance;
        public double CompanyCardBalance;

        public Company(int id, string companyName, double companyMoneyBalance, double companyCardBalance) : base(id)
        {
            CompanyName = companyName;
            CompanyMoneyBalance = companyMoneyBalance;
            CompanyCardBalance = companyCardBalance;

        }
    }
}