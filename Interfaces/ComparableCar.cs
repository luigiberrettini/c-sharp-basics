using Examples.Exceptions;
using System;
using System.Collections;

namespace Examples.Interfaces
{
    public sealed class ComparableCar : IComparable
    {
        private const int MaxSpeed = 100;

        private int CurrentSpeed { get; set; }

        public string PetName { get; private set; }

        public int CarId { get; private set; }

        private bool carIsDead;

        private readonly Radio theMusicBox = new Radio();

        public ComparableCar()
        {
        }

        public ComparableCar(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarId = id;
        }

        public static IComparer SortByPetName
        {
            get
            {
                return new PetNameComparer();
            }
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

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

            var ex = new Exception(string.Format("{0} has overheated!", PetName))
            {
                HelpLink = "http://www.CarsRUs.com"
            };
            ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
            ex.Data.Add("Cause", "You have a lead foot.");
            throw ex;
        }

        //int IComparable.CompareTo(object obj)
        //{
        //    var temp = obj as ComparableCar;
        //
        //    if (temp == null)
        //        throw new ArgumentException("Parameter is not a ComparableCar!");
        //
        //    if (CarId == temp.CarId)
        //        return 0;
        //
        //    return CarId < temp.CarId ? -1 : 1;
        //}

        int IComparable.CompareTo(object obj)
        {
            var temp = obj as ComparableCar;

            if (temp != null)
                return this.CarId.CompareTo(temp.CarId);

            throw new ArgumentException("Parameter is not a ComparableCar!");
        }
    }
}