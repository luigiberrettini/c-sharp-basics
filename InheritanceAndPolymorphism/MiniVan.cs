namespace Examples.InheritanceAndPolymorphism
{
    public class MiniVan : BaseCar
    {
        /*
            A derived class never inherits the constructors of a parent class:
            they are only used to construct the class that they are defined within

            Multiple inheritance is not allowed by C#

            The sealed keyword prevents inheritance (look at String)
            Structures are always implicitly sealed
        */

        public void SetSpeedTo10()
        {
            // OK: can access public members of a parent within a derived type
            Speed = 10;

            // Error: cannot access private members of parent within a derived type
            //currSpeed = 10;
        }
    }
}