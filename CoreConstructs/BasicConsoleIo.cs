using System;

namespace Examples.CoreConstructs
{
    public static class BasicConsoleIo
    {
        public static void Go()
        {
            Console.WriteLine("***** Basic Console I/O *****");
            InputOutput();
            UsePlaceholders();
            FormatNumericalData();
            Console.ReadLine();
        }

        private static void InputOutput()
        {
            const string nameRequestMessage = "Please enter your name: ";
            var userName = RequestUserData(nameRequestMessage);

            const string ageRequestMessage = "Please enter your age: ";
            var userAge = RequestUserData(ageRequestMessage);

            ShowUserData(userName, userAge);
        }

        private static string RequestUserData(string nameRequestMessage)
        {
            Console.Write(nameRequestMessage);
            var userName = Console.ReadLine();
            return userName;
        }

        private static void ShowUserData(string userName, string userAge)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello {0}!  You are {1} years old.", userName, userAge);
            Console.ForegroundColor = prevColor;
        }

        private static void UsePlaceholders()
        {
            Console.WriteLine("{0}, Number {0}, Number {0}", 9);
            Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);
        }

        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
    }
}