using Examples.InheritanceAndPolymorphism;
using System;

namespace Examples.Interfaces
{
    public class ComplexHexagon : Shape, IPointy, IDraw3D
    {
        public ComplexHexagon() { }
        public ComplexHexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0}  the Draw3dHexagon", PetName);
        }

        // IPointy Implementation
        public byte Points
        {
            get { return 6; }
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Draw3dHexagon in 3D!");
        }
    }
}