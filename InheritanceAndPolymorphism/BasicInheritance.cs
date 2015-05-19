using System;

namespace Examples.InheritanceAndPolymorphism
{
    public static class BasicInheritance
    {
        public static void Go()
        {
            Console.WriteLine("***** Basic inheritance *****");

            var myBasicCar = new BaseCar(80) { Speed = 50 };
            Console.WriteLine("My car is going {0} MPH", myBasicCar.Speed);

            var myVan = new MiniVan { Speed = 20 };
            myVan.SetSpeedTo10();
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);

            // Error: cannot access private members
            // myVan.currSpeed = 55;

            Console.ReadLine();
        }
    }
}