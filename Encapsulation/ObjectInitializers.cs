using System;

namespace Examples.Encapsulation
{
    public static class ObjectInitializers
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // Make a ClonablePoint by setting each property manually.
            var firstPoint = new ColoredPoint();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a ClonablePoint via a custom constructor.
            var anotherPoint = new ColoredPoint(20, 20);
            anotherPoint.DisplayStats();

            // Or make a ClonablePoint using object init syntax.
            var finalPoint = new ColoredPoint { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            // Calling a more interesting custom constructor with init syntax
            var goldPoint = new ColoredPoint(PointColor.LightBlue) { X = 90, Y = 20 };
            goldPoint.DisplayStats();
            goldPoint.Color = PointColor.Gold;

            // Create and initialize a ComplexRectangle
            var myRect = new ComplexRectangle
            {
                TopLeft = new ColoredPoint { X = 10, Y = 10 },
                BottomRight = new ColoredPoint { X = 200, Y = 200 }
            };
            myRect.TopLeft = myRect.BottomRight;
            myRect.DisplayStats();

            Console.ReadLine();
        }

    }
}