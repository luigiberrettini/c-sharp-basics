using System;

namespace Examples.Interfaces
{
    public class SimpleOctagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        public void Draw()
        {
            // Shared drawing logic
            Console.WriteLine("Drawing the ComplexOctagon...");
        }
    }
}