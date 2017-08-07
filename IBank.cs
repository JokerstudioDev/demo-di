using System;

namespace demo_di
{
    public interface IBank
    {
        bool Deposit(string username, double amount);
        bool Withdraw(string username, double amount);
    }
}