using System;

namespace Examples.CoreConstructs
{
    public static class TypeConversions
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with type conversions *****");

            const short numb = 30000;
            LossySum(numb, numb);
            CheckedLossySum(numb, numb);
            NarrowingAttempt();

            Console.ReadLine();
        }

        private static void CheckedLossySum(short numb1, short numb2)
        {
            // Tell the compiler to add CIL code to throw an exception if overflow/underflow occurs
            try
            {
                checked
                {
                    LossySum(numb1, numb2);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void LossySum(short numb1, short numb2)
        {
            // Explicit cast of an int into a short (with loss of data)
            var answer = (short)(numb1 + numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
        }

        private static void NarrowingAttempt()
        {
            // Explicit cast of an int to a byte (without loss of data)
            const int myInt = 200;
            const byte myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }
    }
}