using Examples.InheritanceAndPolymorphism;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Examples.Interfaces
{
    public static class CustomInterface
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");

            Shape[] myShapes = { new ComplexHexagon(), new Circle("JoJo"), new Triangle("Joe"), new Complex3DCircle() };

            foreach (var shape in myShapes)
            {
                shape.Draw();

                var shapePointy = shape as IPointy;
                if (shapePointy != null)
                    Console.WriteLine("-> Points: {0}", shapePointy.Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", shape.PetName);
                Console.WriteLine();

                var shapeDrawable3D = shape as IDraw3D;
                if (shapeDrawable3D != null)
                    DrawIn3D(shapeDrawable3D);
            }

            var firstPointyItem = FindFirstPointyShape(myShapes);
            if (firstPointyItem != null)
                Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            IPointy[] myPointyObjects = { new ComplexHexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };

            foreach (var i in myPointyObjects)
                Console.WriteLine("Object has {0} points.", i.Points);

            Console.ReadLine();
        }

        private static void DrawIn3D(IDraw3D itf3D)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3D.Draw3D();
        }

        // This method returns the first object in the array that implements IPointy
        private static IPointy FindFirstPointyShape(IEnumerable<Shape> shapes)
        {
            return shapes.OfType<IPointy>().FirstOrDefault();
        }
    }
}