using System;

namespace demo_di
{
    public class TestBank : IBank
    {
        public bool Deposit(string username, double amount)
        {
            Console.WriteLine($"Deposit {username} amount {amount} by TestBank");
            return false;
        }

        public bool Withdraw(string username, double amount)
        {
            Console.WriteLine($"Withdraw {username} amount {amount} by TestBank");
            return false;
        }
    }
}