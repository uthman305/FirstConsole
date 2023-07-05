using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Interfaces
{
    public interface ICompanyManager
    {
        Company Get(int id);
        Company Get(string companyName);
        
    }
}