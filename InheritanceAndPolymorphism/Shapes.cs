using System;

namespace Examples.InheritanceAndPolymorphism
{
    public static class Shapes
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with shapes *****");

            var hex = new SimpleHexagon("Beth");
            hex.Draw();

            var cir = new Circle("Cindy");
            cir.Draw();  // Calls base class implementation

            Shape[] myShapes = { new SimpleHexagon(), new Circle(), new SimpleHexagon("Mick"), new Circle("Beth"), new SimpleHexagon("Linda") };
            foreach (var s in myShapes)
            {
                Console.WriteLine("{0}Shape name: {1}", Environment.NewLine, s.PetName);
                s.Render();
                s.Draw();
            }

            var o = new Simple3DCircle();
            o.Render();
            o.Draw();
            // Call the methods of the parent
            ((Circle)o).Render();
            ((Circle)o).Draw();

            Console.ReadLine();
        }
    }
}