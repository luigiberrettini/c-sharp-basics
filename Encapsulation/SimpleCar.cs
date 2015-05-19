using System;

namespace Examples.Encapsulation
{
    class SimpleCar
    {
        public string PetName;
        public int CurrSpeed;

        public SimpleCar()
        {
            PetName = "Chuck";
            CurrSpeed = 10;
        }

        // Here currSpeed will receive the default value of an int (zero)
        public SimpleCar(string name)
        {
            PetName = name;
        }

        // Let caller set the full state of the SimpleCar
        public SimpleCar(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH", PetName, CurrSpeed);
        }

        public void SpeedUp(int delta)
        {
            CurrSpeed += delta;
        }
    }
}
