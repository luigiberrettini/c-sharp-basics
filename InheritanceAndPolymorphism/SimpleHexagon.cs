using System;

namespace Examples.InheritanceAndPolymorphism
{
    public class SimpleHexagon : Shape
    {
        public SimpleHexagon()
        {
        }

        public SimpleHexagon(string name)
            : base(name)
        {
        }

        public override void Render()
        {
            Console.WriteLine("Rendering {0} the SimpleHexagon", PetName);
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the SimpleHexagon", PetName);
        }
    }
}