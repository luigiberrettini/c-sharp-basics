using System;

namespace Examples.Encapsulation
{
    public class ComplexCar
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public ComplexCar()
        {

        }

        public ComplexCar(string name, int speed)
        {
            PetName = name;
            Speed = speed;
        }

        public void DisplayStats()
        {
            Console.WriteLine("SimpleCar Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}