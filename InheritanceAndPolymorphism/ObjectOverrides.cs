using System;

namespace Examples.InheritanceAndPolymorphism
{
    public static class ObjectOverrides
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with System.Object *****");

            var p0 = new ComplexPerson();
            Console.WriteLine("p0.ToString() = {0}", p0.ToString());

            // We want these to be identical to test the Equals() and GetHashCode() methods
            var p1 = new ComplexPerson("Homer", "Simpson", 50);
            var p2 = new ComplexPerson("Homer", "Simpson", 50);

            // Get stringified version of objects
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());

            // Test Overridden Equals()
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

            // Test hash codes
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            // Change age of p2 and test again
            p2.Age = 45;
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

            Console.WriteLine();
            StaticMembersOfObject();

            Console.ReadLine();
        }

        private static void StaticMembersOfObject()
        {
            //  Static members of System.Object
            var p3 = new ComplexPerson("Sally", "Jones", 4);
            var p4 = new ComplexPerson("Sally", "Jones", 4);
            Console.WriteLine("P3 and P4 have same state: {0}", Equals(p3, p4));
            Console.WriteLine("P3 and P4 are pointing to same object: {0}", ReferenceEquals(p3, p4));
        }
    }
}