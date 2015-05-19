using System;

namespace Examples.Interfaces
{
    public sealed class ComplexOctagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        /*
            Name clash between different interfaces can be resolved using the explicit interface implementation syntax:
            returnType InterfaceName.MethodName(params){}

            Explicitly implemented members are automatically private (no access modifier can be specified)
            and explicit casting is needed to access the required functionality
        */

        // Explicitly bind Draw() implementations to a given interface
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a printer...");
        }
    }
}