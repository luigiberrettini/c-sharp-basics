using System;

namespace Examples.Exceptions
{
    public static class MultipleExceptions
    {
        // Where at all possible, always favor catching specific exception classes, rather than a general System.Exception
        public static void Go()
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****");

            var myCar = new ExceptionalCar("Rusty", 90);
            try
            {
                // Trigger an argument out of range exception
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadExceptionComplex e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                // This will catch any other exception beyond CarIsDeadExceptionComplex or ArgumentOutOfRangeException
                Console.WriteLine(e.Message);
            }
            finally
            {
                // This will always occur, exception or not
                myCar.CrankTunes(false);
            }

            Console.ReadLine();
        }
    }
}