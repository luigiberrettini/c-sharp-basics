using System;
using System.Linq;

namespace Examples.CoreConstructs
{
    public static class ImplicitlyTypedLocalVars
    {
        //public class ThisWillNeverCompile
        //{
        //    // Cannot be used with member field
        //    private var myInt = 10;
        //
        //    // Cannot be used as a return value or parameter type
        //    public var MyMethod(var x, var y) { }
        //
        //    public void WrongSyntax()
        //    {
        //        // Must assign a value
        //        var myData;
        //
        //        // Must assign value at exact time of declaration
        //        var myInt;
        //        myInt = 0;
        //
        //        // Can't assign null as initial value
        //        var myObj = null;
        //    }
        //}

        public static void Go()
        {
            Console.WriteLine("***** Fun wwith Implicit Typing *****");

            DeclareExplicitVars();
            DeclareImplicitVars();
            LinqQueryOverInts();

            Console.ReadLine();
        }

        private static void DeclareExplicitVars()
        {
            // Explicitly typed local variables
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on... ";

            // Print out the data type
            Console.WriteLine("explicit myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("explicit myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("explicit myString is a: {0}", myString.GetType().Name);
        }

        private static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying data type
            Console.WriteLine("implicit myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("implicit myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("implicit myString is a: {0}", myString.GetType().Name);

            // Implicit typing is strong typing
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            var upper = s.ToUpper();

            // Error! Can't assign numerical data to a string!
            // s = 44;
        }


        private static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers
                         where i < 10
                         select i;

            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}