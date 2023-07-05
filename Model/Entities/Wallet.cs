using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardConsole.Model.Entities
{
    public class Wallet : BaseEntity
    {
        public string WalletId;
        public int Pin;
        public double MoneyBalance;
        public double CardBalance;
        public double AdminMoneyBalance;
        public double AdminCardBalance;
        public Wallet(int id, string walletId, int pin, double moneyBalance, double cardBalance, double adminMoneyBalance, double adminCardBalance) : base(id)
        {
            WalletId = walletId;
            Pin = pin;
            MoneyBalance = moneyBalance;
            CardBalance = cardBalance;
            AdminMoneyBalance = adminMoneyBalance;
            AdminCardBalance = adminCardBalance;

        }
    }
}