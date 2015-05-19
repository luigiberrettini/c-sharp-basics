using System;

namespace Examples.InheritanceAndPolymorphism
{
    // Salespeople need to know their number of sales
    public class BaseSalesPerson : BaseEmployee
    {
        public int SalesNumber { get; private set; }

        // As a general rule, all subclasses should explicitly call an appropriate base class constructor
        public BaseSalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empId, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }

        public BaseSalesPerson()
        {
        }

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus;

            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
                salesBonus = SalesNumber >= 101 && SalesNumber <= 200 ? 15 : 20;

            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
    }
}