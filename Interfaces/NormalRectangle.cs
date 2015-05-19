using System;

namespace Examples.Interfaces
{
    class NormalRectangle : IShape
    {
        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        public void Print()
        {
            Console.WriteLine("Prining...");
        }
    }
}