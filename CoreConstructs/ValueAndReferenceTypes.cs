using System;

namespace Examples.CoreConstructs
{
    public static class ValueAndReferenceTypes
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with value types and reference types *****\n");

            ValueTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainingRefTypeAssignment();
            PassingRefTypesByValue();
            PassingRefTypesByRef();

            Console.ReadLine();
        }

        private static void ValueTypeAssignment()
        {
            Console.WriteLine("=> Assigning value types");

            // Two independent variables on the stack
            var p1 = new SimplePoint(10, 10);
            var p2 = p1;

            // Print both points
            p1.Display();
            p2.Display();

            // Change p1.X and print again: p2.X is not changed
            p1.X = 100;
            p1.Y = 200;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();

            Console.WriteLine();
        }

        private static void ReferenceTypeAssignment()
        {
            Console.WriteLine("=> Assigning reference types");
            var p1 = new ComplexPoint(10, 10);
            p1.Increment();
            p1.Decrement();
            var p2 = p1;

            // Print both point refs
            p1.Display();
            p2.Display();

            // Change p1.X and print again
            p1.X = 100;
            p1.Y = 200;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();

            Console.WriteLine();
        }

        private static void ValueTypeContainingRefTypeAssignment()
        {
            Console.WriteLine("=> Assigning value types containing reference types");

            Console.WriteLine("-> Creating r1");
            var r1 = new SimpleRectangle("First Rect", 10, 10, 50, 50);

            Console.WriteLine("-> Assigning r2 to r1");
            var r2 = r1;

            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;

            r1.Display();
            r2.Display();

            Console.WriteLine();
        }

        private static void PassingRefTypesByValue()
        {
            Console.WriteLine("=> Passing SimplePerson object by value");

            var fred = new SimplePerson("Fred", 12);
            Console.WriteLine("\nBefore by value call, SimplePerson is:");
            fred.Display();
            SendAPersonByValue(fred);

            Console.WriteLine("\nAfter by value call, SimplePerson is:");
            fred.Display();

            Console.WriteLine();
        }

        private static void PassingRefTypesByRef()
        {
            Console.WriteLine("=> Passing SimplePerson object by ref");

            var mel = new SimplePerson("Mel", 23);
            Console.WriteLine("Before by ref call, SimplePerson is:");
            mel.Display();

            SendAPersonByReference(ref mel);

            Console.WriteLine("After by ref call, SimplePerson is:");
            mel.Display();

            Console.WriteLine();
        }

        private static void SendAPersonByValue(SimplePerson p)
        {
            // Change the age of "p"?
            p.PersonAge = 99;

            // Will the caller see this reassignment?
            p = new SimplePerson("Nikki", 99);
        }

        private static void SendAPersonByReference(ref SimplePerson p)
        {
            // Change some data of "p".
            p.PersonAge = 555;

            // "p" is now pointing to a new object on the heap!
            p = new SimplePerson("Nikki", 999);
        }
    }
}