using System;

namespace Examples.CoreConstructs
{
    public static class Iterations
    {
        public static void Go()
        {
            Console.WriteLine("***** Loops *****");

            ForLoopExample();
            Console.WriteLine();

            ForEachLoopExample();
            Console.WriteLine();

            WhileLoopExample();
            Console.WriteLine();

            DoWhileLoopExample();
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void ForLoopExample()
        {
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here
        }

        private static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (var c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 30, 40 };
            foreach (var i in myInts)
                Console.WriteLine(i);
        }

        private static void WhileLoopExample()
        {
            var userIsDone = "";

            while (userIsDone != null && userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("Inside a while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        private static void DoWhileLoopExample()
        {
            string userIsDone;

            do
            {
                Console.Write("Inside a do-while loop\nAre you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone != null && userIsDone.ToLower() != "yes");
            // Note the semicolon!
        }
    }
}