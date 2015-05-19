using System;

namespace Examples.Encapsulation
{
    public static class StaticDataAndMembers
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Static Data *****");

            var s1 = new SavingsAccount(50);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            SavingsAccount.SetInterestRate(0.08);
            var s2 = new SavingsAccount(100);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            s2.CurrBalance = 1000;

            SavingsAccount.InterestRate = 0.08;
            var s3 = new SavingsAccount(100);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);
            s3.CurrBalance = 1000;

            Console.ReadLine();
        }
    }
}