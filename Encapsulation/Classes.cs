using System;

namespace Examples.Encapsulation
{
    public static class Classes
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Class Types *****");

            MakeSomeBikes();
            MakeSomeCars();

            Console.ReadLine();
        }

        private static void MakeSomeCars()
        {
            // Allocate and configure a SimpleCar object
            var myComplexCar = new SimpleCar();
            myComplexCar.PetName = "Henry";
            myComplexCar.CurrSpeed = 10;

            // Speed up the car a few times and print out the new state
            for (var i = 0; i <= 10; i++)
            {
                myComplexCar.SpeedUp(5);
                myComplexCar.PrintState();
            }

            // Make a SimpleCar called Chuck going 10 MPH (default constructor)
            var chuck = new SimpleCar();
            chuck.PrintState();

            // Make a SimpleCar called Mary going 0 MPH
            var mary = new SimpleCar("Mary");
            mary.PrintState();

            // Make a SimpleCar called Daisy going 75 MPH
            var daisy = new SimpleCar("Daisy", 75);
            daisy.PrintState();
        }

        private static void MakeSomeBikes()
        {
            var m1 = new Motorcycle();
            m1.PopAWheely();
            Console.WriteLine("Name= {0}, Intensity= {1}", m1.DriverName, m1.DriverIntensity);

            var m2 = new Motorcycle(5);
            m2.SetDriverName("Tiny");
            m2.PopAWheely();
            Console.WriteLine("Name= {0}, Intensity= {1}", m2.DriverName, m2.DriverIntensity);

            // driverName = "", driverIntensity = 0  
            var m3 = new Motorcycle();
            Console.WriteLine("Name= {0}, Intensity= {1}", m3.DriverName, m3.DriverIntensity);

            // driverName = "Tiny", driverIntensity = 0 
            var m4 = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name= {0}, Intensity= {1}", m4.DriverName, m4.DriverIntensity);

            // driverName = "", driverIntensity = 7  
            var m5 = new Motorcycle(7);
            Console.WriteLine("Name= {0}, Intensity= {1}", m5.DriverName, m5.DriverIntensity);
        }
    }
}