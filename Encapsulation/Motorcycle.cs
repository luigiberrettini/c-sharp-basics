using System;

namespace Examples.Encapsulation
{
    class Motorcycle
    {
        public readonly int DriverIntensity;
        //public string name;
        public string DriverName;

        /*
            As soon as you define a custom constructor with any number of parameters, the default constructor is silently removed from the class
            If you do not define a custom constructor, the C# compiler grants you a default
            When you define a unique constructor, the compiler assumes you have taken matters into your own hands
            To allow the object user to create an instance of your type with default and custom constructors you must explicitly redefine the default
            In many cases, the implementation of the default constructor is intentionally empty, allow the creation of an object with default values

            ctor snippet

            this: try uncommenting name
        */

        // Constructor chaining
        //public Motorcycle()
        //{
        //    Console.WriteLine("In default ctor");
        //}
        //
        //public Motorcycle(int intensity) : this(intensity, "")
        //{
        //    Console.WriteLine("In ctor taking an int");
        //}
        //
        //public Motorcycle(string name) : this(0, name)
        //{
        //    Console.WriteLine("In ctor taking a string");
        //}
        //
        //// This is the 'master' constructor that does all the real work.
        //public Motorcycle(int intensity, string name)
        //{
        //    Console.WriteLine("In master ctor ");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        // Single constructor using optional args
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            DriverIntensity = intensity;
            DriverName = name;
        }

        public void PopAWheely()
        {
            for (var i = 0; i <= DriverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        public void SetDriverName(string name)
        {
            //name = name;
            DriverName = name;
        }
    }
}