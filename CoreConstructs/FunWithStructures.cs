using System;

namespace Examples.CoreConstructs
{
    public static class FunWithStructures
    {
        public static void Go()
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            // Create an initial SimplePoint
            SimplePoint myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Call custom constructor
            var p2 = new SimplePoint(50, 60);

            // Prints X=50, Y=60
            p2.Display();

            // Adjust the X and Y values
            myPoint.Increment();
            myPoint.Display();

            // Adjust the X and Y values
            myPoint.Decrement();
            myPoint.Display();

            Console.ReadLine();
        }
    }
}