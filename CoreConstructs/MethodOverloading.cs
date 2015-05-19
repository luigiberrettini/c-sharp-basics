using System;

namespace Examples.CoreConstructs
{
    public static class MethodOverloading
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            // int version of Add()
            Console.WriteLine(Add(10, 10));

            // long version of Add()
            Console.WriteLine(Add(900000000000, 900000000000));

            // double version of Add()
            Console.WriteLine(Add(4.3, 4.4));

            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static long Add(long x, long y)
        {
            return x + y;
        }
    }
}