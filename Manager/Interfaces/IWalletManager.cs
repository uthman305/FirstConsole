using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardConsole.Model.Entities;
using CardConsole.Model.Enum;

namespace CardConsole.Manager.Interfaces
{
    public interface IWalletManager
    {
        public Wallet Open(string firstName, string lastName, string email, string password, string phoneNumber, DateTime dob, Gender gender);
        public Wallet Get(string walletId);
        public Wallet Get(int id);

    }
}