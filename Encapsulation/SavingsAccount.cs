using System;

namespace Examples.Encapsulation
{
    public class SavingsAccount
    {
        // Instance level data
        public double CurrBalance;

        // Class level data (static)
        private static double currInterestRate;

        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }

        public SavingsAccount(double balance)
        {
            CurrBalance = balance;
        }

        // Static constructor
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}