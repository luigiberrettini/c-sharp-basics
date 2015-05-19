using System;

namespace Examples.Exceptions
{
    public class ExceptionalCar
    {
        private const int MaxSpeed = 100;

        private int CurrentSpeed { get; set; }

        private string PetName { get; set; }

        private bool carIsDead;

        // A car has-a radio
        private readonly Radio theMusicBox = new Radio();

        public ExceptionalCar()
        {
        }

        public ExceptionalCar(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object
            theMusicBox.TurnOn(state);
        }

        // See if ExceptionalCar has overheated: throw an exception if the user speeds up beyond MaxSpeed
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
                return;
            }

            CurrentSpeed += delta;
            if (CurrentSpeed < MaxSpeed)
            {
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                return;
            }

            carIsDead = true;
            CurrentSpeed = 0;

            // We need to call the HelpLink property, thus we need to create a local variable before throwing the Exception object
            var ex = new CarIsDeadExceptionComplex(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now)
            {
                HelpLink = "http://www.CarsRUs.com"
            };

            // Stuff in custom data regarding the error
            ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
            ex.Data.Add("Cause", "You have a lead foot");
            throw ex;
        }
    }
}