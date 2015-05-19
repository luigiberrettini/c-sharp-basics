using Examples.Encapsulation;
using System;

namespace Examples.Interfaces
{
    public static class CustomEnumerator
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****");
            var carLot = new ComplexGarage();

            foreach (ComplexCar c in carLot)
                Console.WriteLine("{0} is going {1} MPH and is {2}", c.PetName, c.Speed, c.Color);

            // Manually work with IEnumerator
            var i = carLot.GetEnumerator();
            i.MoveNext();
            var myCar = (ComplexCar)i.Current;
            Console.WriteLine("{0} is going {1} MPH and is {2}", myCar.PetName, myCar.Speed, myCar.Color);

            // Get items (in reverse!) using named iterator
            foreach (ComplexCar c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH",
                  c.PetName, c.Speed);
            }

            Console.ReadLine();
        }
    }
}