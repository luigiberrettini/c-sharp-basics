using System;

namespace Examples.Interfaces
{
    public static class InterfaceHierarchy
    {
        public static void Go()
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****");

            // Call from object level.
            var myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            // Get IAdvancedDraw explicitly
            var iAdvDraw = myBitmap as IAdvancedDraw;
            iAdvDraw.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}