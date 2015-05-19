namespace Examples.Encapsulation
{
    public class SimpleGarage
    {
        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; }

        // The hidden SimpleCar backing field is set to null!
        public ComplexCar MyAuto { get; set; }

        // Must use constructors to override default values assigned to hidden backing fields
        public SimpleGarage()
        {
            MyAuto = new ComplexCar();
            NumberOfCars = 1;
        }

        public SimpleGarage(ComplexCar complexCar, int number)
        {
            MyAuto = complexCar;
            NumberOfCars = number;
        }
    }
}