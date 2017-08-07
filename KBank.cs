using System;

namespace demo_di
{
    public class KBank : IBank
    {
        public bool Deposit(string username, double amount)
        {
            Console.WriteLine($"Deposit {username} amount {amount} by KBank");
            return true;
        }

        public bool Withdraw(string username, double amount)
        {
            Console.WriteLine($"Withdraw {username} amount {amount} by KBank");
            return true;
        }
    }
}