using System;

namespace Examples.Encapsulation
{
    /*
        When a class has been defined as static, it is not creatable using the new keyword,
        and it can contain only members or data fields marked with the static keyword
    */
    public static class UtilityClasses
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Static Classes *****");

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            // Compiler error: can't create static classes!
            // TimeUtilClass u = new TimeUtilClass();

            Console.ReadLine();
        }
    }
}