using System;

namespace demo_di
{
    public class KTC : IBank
    {
        public bool Deposit(string username, double amount)
        {
            Console.WriteLine($"Deposit {username} amount {amount} by KTC");
            return true;
        }

        public bool Withdraw(string username, double amount)
        {
            Console.WriteLine($"Withdraw {username} amount {amount} by KTC");
            return true;
        }
    }
}