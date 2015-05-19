using System;

namespace Examples.Interfaces
{
    public static class InterfaceNameClash
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****");

            DrawSimpleOctagon();
            DrawComplexOctagon();

            Console.ReadLine();
        }

        private static void DrawSimpleOctagon()
        {
            var simpleOct = new SimpleOctagon();

            simpleOct.Draw();

            var itfFormSimpleOct = (IDrawToForm)simpleOct;
            itfFormSimpleOct.Draw();

            ((IDrawToPrinter)simpleOct).Draw();

            if (simpleOct is IDrawToMemory)
            {
                ((IDrawToMemory)simpleOct).Draw();
            }
        }

        private static void DrawComplexOctagon()
        {
            var complexOctagon = new ComplexOctagon();

            // We must use casting to access the Draw() members
            var itfFormComplexOct = (IDrawToForm)complexOctagon;
            itfFormComplexOct.Draw();

            // Shorthand notation if you don't need the interface variable for later use
            ((IDrawToPrinter)complexOctagon).Draw();

            // Could also use the "as" keyword
            if (complexOctagon is IDrawToMemory)
            {
                ((IDrawToMemory)complexOctagon).Draw();
            }
        }
    }
}