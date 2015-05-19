using System;

namespace Examples.InheritanceAndPolymorphism
{
    // Circle DOES NOT override Render()
    // If we did not implement Draw(), Circle would be considered abstract and would have to be marked abstract
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
}