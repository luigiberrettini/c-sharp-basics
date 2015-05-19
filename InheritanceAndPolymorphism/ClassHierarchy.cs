using System;

namespace Examples.InheritanceAndPolymorphism
{
    public static class ClassHierarchy
    {
        public static void Go()
        {
            Console.WriteLine("***** The BaseEmployee class hierarchy *****");

            var manager = new Manager();
            manager.DisplayStats();

            var chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            var salesPerson = new BaseSalesPerson();
            salesPerson.DisplayStats();

            var fran = new BaseSalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            Console.WriteLine();
            CastingExamples();

            Console.ReadLine();
        }

        private static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can store a Manager reference in an object variable just fine
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            // A Manager "is-a" BaseEmployee
            BaseEmployee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            // A PartTimeBaseSalesPerson "is-a" BaseSalesPerson
            BaseSalesPerson jill = new PartTimeBaseSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);

        }
        private static void GivePromotion(BaseEmployee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is BaseSalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name,
                    ((BaseSalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }

            var empAsManager = emp as Manager;
            if (empAsManager == null)
                return;

            Console.WriteLine("{0} had {1} stock options...", empAsManager.Name, empAsManager.StockOptions);
            Console.WriteLine();
        }
    }
}