using System;

namespace Examples.Exceptions
{
    public static class CustomException
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");
            var myExceptionalCar = new ExceptionalCar("Rusty", 90);

            try
            {
                // Trip exception.
                myExceptionalCar.Accelerate(50);
            }
            catch (CarIsDeadExceptionComplex e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            Console.ReadLine();
        }

    }
}