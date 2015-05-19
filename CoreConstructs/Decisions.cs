using System;

namespace Examples.CoreConstructs
{
    public static class Decisions
    {
        public static void Go()
        {
            /*
                A < B       Returns true if expression A is less than expression B
                A <= B      Returns true if expression A is less than or equal to expression B
                A == B      Returns true only if each expression is the same
                A > B       Returns true if expression A is greater than expression B
                A >= B      Returns true if expression A is greater than or equal to expression B
                A != B      Returns true only if each expression is different

                A && B      AND operator: returns true if all expressions are true
                            Short circuit when A has been determined to be false
                A || B      OR operator: returns true if at least one expression is true
                            Short circuit when A has been determined to be true                            
                !A          NOT operator: returns true if false, or false if true
            */

            Console.WriteLine("***** Decisions *****");

            IfElseExample();
            Console.WriteLine();

            SwitchOnNumeric();
            Console.WriteLine();

            SwitchOnString();
            Console.WriteLine();

            SwitchOnEnum();
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void IfElseExample()
        {
            const string stringData = "My textual data";

            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
        }

        private static void SwitchOnNumeric()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            var langChoice = Console.ReadLine() ?? "";
            var n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        private static void SwitchOnString()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            var langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        private static void SwitchOnEnum()
        {
            Console.Write("Enter your favorite day of the week: ");

            var input = Console.ReadLine();
            DayOfWeek favDay;
            if (!Enum.TryParse(input, out favDay))
                favDay = DayOfWeek.Monday;

            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                default:
                    Console.WriteLine("Sorry, no idea what you typed!");
                    break;
            }
        }
    }
}