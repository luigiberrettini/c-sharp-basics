using System;
using System.Collections;

namespace Examples.Interfaces
{
    public sealed class PetNameComparer : IComparer
    {
        // This helper class is used to sort an array of Cars by pet name
        int IComparer.Compare(object o1, object o2)
        {
            var t1 = o1 as ComparableCar;
            var t2 = o2 as ComparableCar;
            if (t1 != null && t2 != null)
                return String.CompareOrdinal(t1.PetName, t2.PetName);
            throw new ArgumentException("Parameter is not a ComparableCar!");
        }
    }
}