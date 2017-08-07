using System;

namespace demo_di
{
    public class BalancePayment
    {
        private IBank bank;
        public BalancePayment(IBank bank)
        {
            this.bank = bank;
        }

        public bool Deposit(string username, double amount)
        {
            var isinvalid = string.IsNullOrEmpty(username);
            if(isinvalid) return false;
            return bank.Deposit(username, amount);
        }

        public bool Withdraw(string username, double amount)
        {
            var isinvalid = string.IsNullOrEmpty(username);
            if(isinvalid) return false;
            if(amount < 100) return false;
            return bank.Withdraw(username, amount);
        }
            
    }
}