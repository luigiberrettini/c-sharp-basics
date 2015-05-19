using System;

namespace Examples.InheritanceAndPolymorphism
{
    // Managers need to know their number of stock options
    public class Manager : BaseEmployee
    {
        public int StockOptions { get; private set; }

        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empId, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }

        public Manager()
        {
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            var r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}