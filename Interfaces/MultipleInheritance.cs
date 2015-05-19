using System;

namespace Examples.Interfaces
{
    public static class MultipleInheritance
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with multiple inheritance with interfaces *****");

            var s = new Square();
            s.Print();
            s.GetNumberOfSides();
            // s.Draw();
            ((IDrawable)s).Draw();
            ((IPrintable)s).Draw();

            var r = new NormalRectangle();
            r.Print();
            r.GetNumberOfSides();
            r.Draw();
            ((IDrawable)r).Draw();
            ((IPrintable)r).Draw();

            Console.ReadLine();
        }
    }
}