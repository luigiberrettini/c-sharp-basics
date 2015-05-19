using System;

namespace Examples.Interfaces
{
    public static class Clonable
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Object Cloning *****");

            Console.WriteLine("Cloned p3 and stored new ColoredPoint in p4");
            var p3 = new ClonablePoint(100, 100, "Jane");
            var p4 = (ClonablePoint)p3.Clone();

            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.Desc.PetName = "My new ColoredPoint";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            Console.ReadLine();
        }
    }
}