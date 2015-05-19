using System;
using System.Collections.Generic;

namespace Examples.Interfaces
{
    public static class Comparable
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Object Sorting *****");

            var myAutos = new ComparableCar[5];
            myAutos[0] = new ComparableCar("Rusty", 80, 1);
            myAutos[1] = new ComparableCar("Mary", 40, 234);
            myAutos[2] = new ComparableCar("Viper", 40, 34);
            myAutos[3] = new ComparableCar("Mel", 40, 4);
            myAutos[4] = new ComparableCar("Chucky", 40, 5);
            PrintCars("Here is the unordered set of cars:", myAutos);

            Array.Sort(myAutos);
            PrintCars("Here is the ordered set of cars:", myAutos);

            // Dump sorted array and sort by pet name
            // Array.Sort(myAutos, new PetNameComparer());

            // Sorting by pet name made a bit cleaner
            Array.Sort(myAutos, ComparableCar.SortByPetName);
            PrintCars("Ordering by pet name:", myAutos);

            Console.ReadLine();
        }

        private static void PrintCars(string message, IEnumerable<ComparableCar> myAutos)
        {
            Console.WriteLine(message);
            foreach (var c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarId, c.PetName);
            }
        }
    }
}