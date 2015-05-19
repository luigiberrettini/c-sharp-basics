using System;

namespace Examples.Encapsulation
{
    public static class AutoProps
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Automatic Properties *****");

            // Make a car
            var c1 = new ComplexCar();
            c1.PetName = "Frank";
            c1.Speed = 55;
            c1.Color = "Red";
            c1.DisplayStats();

            var c2 = new ComplexCar {PetName = "Frank", Speed = 55, Color = "Red"};
            c2.DisplayStats();

            // Put car in the garage
            var g1 = new SimpleGarage();
            g1.MyAuto = c1;
            Console.WriteLine("Number of Cars in garage: {0}", g1.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g1.MyAuto.PetName);

            var g2 = new SimpleGarage { MyAuto = c1 };
            g2.NumberOfCars++;
            Console.WriteLine("Number of Cars in garage: {0}", g2.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g2.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}