using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Manager.Interfaces;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Implementations
{
    public class CompanyManager : ICompanyManager
    {

        public static List<Company> CompanyDb = new List<Company>();

        public Company Get(int id)
        {
            foreach (var company in CompanyDb)
            {
                if (company.Id == id)
                {
                    return company;
                }
            }
            return null;
        }

        public Company Get(string companyName)
        {
            foreach (var company in CompanyDb)
            {
                if (company.CompanyName == companyName)
                {
                    return company;
                }
            }
            return null;
        }

    }
}