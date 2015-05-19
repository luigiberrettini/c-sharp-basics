using System;
using System.Linq;

namespace Examples.CoreConstructs
{
    public static class FunWithMethods
    {
        public static void Go()
        {
            /*
            None        If a parameter is not marked with a parameter modifier, it is assumed to be passed by value,
                        meaning the called method receives a copy of the original data

            out         Output parameters must be assigned by the method being called, and therefore, are passed by reference
                        If the called method fails to assign output parameters, you are issued a compiler error
            
            ref         The value is initially assigned by the caller and may be optionally reassigned by the called method
                        (as the data is also passed by reference).
                        No compiler error is generated if the called method fails to assign a ref parameter

            params      This parameter modifier allows you to send in a variable number of arguments as a single logical parameter
                        A method can have only a single params modifier and it must be the final parameter of the method
            */

            Console.WriteLine("***** Fun with Methods *****\n");

            // Pass two variables in by value
            const int x = 9;
            const int y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.WriteLine();

            // Do not initialize local variables used as output parameters
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);

            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.WriteLine();

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1} ", str1, str2);

            Console.WriteLine();

            // Pass a comma-delimited list of doubles
            var average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            // Pass an array of doubles
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            // Average of 0 is 0
            Console.WriteLine("Average of data is: {0}", CalculateAverage());

            Console.WriteLine();
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data", "CFO");

            Console.WriteLine();
            DisplayFancyMessage(message: "Wow!  Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);
            DisplayFancyMessage(message: "Hello!");
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green);

            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            var ans = x + y;

            // Caller will not see these changes as you are modifying a copy of the original data
            x = 10000;
            y = 88888;

            return ans;
        }

        private static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        private static void SwapStrings(ref string s1, ref string s2)
        {
            var tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        private static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);

            if (values.Length == 0)
                return 0;

            return values.Sum() / values.Length;
        }

        // Optional parameters must always be packed onto the end of a method signature
        // It is a compiler error to have optional parameters listed before nonoptional parameters
        private static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        private static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
        {
            // Store old colors to restore once message is printed
            var oldTextColor = Console.ForegroundColor;
            var oldbackgroundColor = Console.BackgroundColor;

            // Set new colors and print message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            // Restore previous colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}