namespace Examples.InheritanceAndPolymorphism
{
    public class BaseCar
    {
        private readonly int maxSpeed;
        private int currSpeed;

        public BaseCar(int max)
        {
            maxSpeed = max;
        }

        protected BaseCar()
        {
            maxSpeed = 55;
        }

        public int Speed
        {
            get { return currSpeed; }
            set { currSpeed = value <= maxSpeed ? value : maxSpeed; }
        }
    }
}