using System;

namespace Examples.Encapsulation
{
    public static class ConstData
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.Pi);

            // Error: can't change a constant
            // MyMathClass.PI = 3.1444;

            Console.ReadLine();
        }
    }
}