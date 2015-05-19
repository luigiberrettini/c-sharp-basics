using System;
using System.Collections;

namespace Examples.Exceptions
{
    public static class SimpleException
    {
        public static void Go()
        {
            Console.WriteLine("***** Simple Exception Example *****");

            Console.WriteLine("=> Creating a basic car!");
            var basicCar = new ExceptionalCar();
            basicCar.Accelerate(1);

            Console.WriteLine("=> Creating a car and stepping on it!");
            var myCar = new ExceptionalCar("Zippy", 20);
            myCar.CrankTunes(true);

            // Speed up past the car's max speed to trigger the exception
            try
            {
                for (var i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");

                // TargetSite returns a MethodBase object
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);

                Console.WriteLine("\n-> Custom Data");
                // e.Data default is a null collection in .NET framework 4.0
                //if (e.Data != null)
                //{
                // e.Data default is an empty collection in .NET framework 4.5 and 4.6
                if (e.Data.Count > 0)
                {
                    Console.WriteLine("   {0} items", e.Data.Count);

                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("    - {0}: {1}", de.Key, de.Value);
                }
            }

            // The error has been handled and processing continues with the next statement
            Console.WriteLine("\n***** Out of exception logic *****");

            Console.ReadLine();
        }
    }
}