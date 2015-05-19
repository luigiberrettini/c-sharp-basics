using Examples.Encapsulation;
using System.Collections;

namespace Examples.Interfaces
{
    public class ComplexGarage : IEnumerable
    {
        private readonly ComplexCar[] complexCarArray = new ComplexCar[4];

        public ComplexGarage()
        {
            complexCarArray[0] = new ComplexCar("Rusty", 30);
            complexCarArray[1] = new ComplexCar("Clunker", 55);
            complexCarArray[2] = new ComplexCar("Zippy", 30);
            complexCarArray[3] = new ComplexCar("Fred", 30);
        }

        /*
            Returns a reference to the interface System.Collections.IEnumerator, that provides the infrastructure to
            allow the caller to traverse the internal objects contained by the IEnumerable-compatible container:

            // This interface allows the caller to obtain a container's subitems
            public interface IEnumerator
            {
                bool MoveNext (); // Advance the internal position of the cursor.
                object Current { get;} // Get the current item (read-only property).
                void Reset (); // Reset the cursor before the first member.
            }

            To hide the functionality of IEnumerable from the object level, simply make use of explicit interface implementation:
            IEnumerator IEnumerable.GetEnumerator()
            {
                // Return the array object's IEnumerator
                return complexCarArray.GetEnumerator();
            }
            
            Doing so, the casual object user will not find the Garage’s GetEnumerator() method, while
            the foreach construct will obtain the interface in the background when necessary
        */
        public IEnumerator GetEnumerator()
        {
            // Return the array object's IEnumerator
            return complexCarArray.GetEnumerator();

            /*
            foreach (ComplexCar c in complexCarArray)
            {
                yield return c;
            }
            */
        }

        public IEnumerable GetTheCars(bool returnRevesed)
        {
            if (returnRevesed)
            {
                // Return the items in reverse
                for (var i = complexCarArray.Length; i != 0; i--)
                    yield return complexCarArray[i - 1];
            }
            else
            {
                // Return the items as placed in the array
                foreach (var c in complexCarArray)
                    yield return c;
            }
        }
    }
}