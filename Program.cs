using System;

namespace demo_di
{
    class Program
    {
        static void Main(string[] args)
        {
            var balancePayment = new BalancePayment(ktc);
            var result = balancePayment.Withdraw("Ploy", 1000);
            if(result) Console.WriteLine("Success");
            else Console.WriteLine("Fail");
        }
    }
}