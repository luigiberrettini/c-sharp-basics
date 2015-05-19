using System;

namespace Examples.CoreConstructs
{
    public static class FunWithArrays
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Arrays *****");

            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();

            Console.ReadLine();
        }

        private static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization");

            // Create, fill and print an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (var i in myInts)
                Console.WriteLine(i);

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        private static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization");

            // a is really int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());

            Console.WriteLine();
        }

        private static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        private static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            // Populate (6 * 6) array.
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;

            // Print (6 * 6) array.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array");

            // Here we have an array of 5 different arrays (jagged MD array = an array of arrays)
            int[][] myJagArray = new int[5][];

            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember that each element is defaulted to zero)
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values");

            // Pass array as parameter
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value.
            var strs = GetStringArray();
            foreach (var s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }

        private static void PrintArray(int[] myInts)
        {
            for (var i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        private static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        private static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array");

            // Initialize items at startup and print them
            Console.WriteLine("-> Here is the array:");
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
            foreach (var gothicBand in gothicBands)
                Console.Write(gothicBand + ", ");
            Console.WriteLine("\n");

            // Reverse and print them
            Console.WriteLine("-> The reversed array");
            Array.Reverse(gothicBands);
            foreach (var gothicBand in gothicBands)
                Console.Write(gothicBand + ", ");
            Console.WriteLine("\n");

            // Clear out all but the final member
            Console.WriteLine("-> Cleared out all but one");
            Array.Clear(gothicBands, 1, 2);
            foreach (var gothicBand in gothicBands)
                Console.Write(gothicBand + ", ");

            Console.WriteLine();
        }
    }
}