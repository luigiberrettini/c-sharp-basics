using System;

namespace Examples.InheritanceAndPolymorphism
{
    public abstract class Shape
    {
        protected Shape(string name = "NoName")
        {
            PetName = name;
        }

        protected Shape()
        {
        }

        public string PetName { get; private set; }

        public virtual void Render()
        {
            Console.WriteLine("Inside Shape.Render");
        }

        // Force all child classes to define how to be drawn
        public abstract void Draw();
    }
}