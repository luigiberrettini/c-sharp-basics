using System;

namespace Examples.Encapsulation
{
    public static class AccessorsMutatorsAndProps
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Encapsulation *****");

            var emp = new SimpleEmployee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            // Set and get the Name property
            emp.Name = "Marv";
            Console.WriteLine("SimpleEmployee is named: {0}", emp.Name);

            // Longer than 15 characters: error will be printed to console
            var emp2 = new SimpleEmployee();
            Console.WriteLine("SimpleEmployee data: {0}\t{1}\t{2}", emp2.Id, emp2.Pay, emp2.Age);
            emp2.Id = 53;
            emp2.Pay = 34;
            emp2.Age = 45;
            Console.WriteLine("SimpleEmployee data: {0}\t{1}\t{2}", emp2.Id, emp2.Pay, emp2.Age);
            emp2.SetName("Xena the warrior princess");

            Console.ReadLine();
        }
    }
}