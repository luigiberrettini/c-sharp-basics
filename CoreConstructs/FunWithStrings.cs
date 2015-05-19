using System;
using System.Text;

namespace Examples.CoreConstructs
{
    public static class FunWithStrings
    {
        public static void Go()
        {
            Console.WriteLine("***** Fun with Strings *****\n");

            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            VerbatimStrings();
            StringEquality();
            StringsAreImmutable();
            FunWithStringBuilder();

            Console.ReadLine();
        }

        private static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality");

            const string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));

            Console.WriteLine();
        }

        private static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation");

            const string s1 = "Programming the ";
            const string s2 = "PsychoDrill (PTP)";
            var s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);

            Console.WriteLine();
        }

        private static void EscapeChars()
        {
            /*
                \'      Inserts a single quote into a string literal
                \"      Inserts a double quote into a string literal
                \\      Inserts a backslash into a string literal (helpful when defining file or network paths)
                \a      Triggers a system alert, i.e. a beep (can be an audio clue to users of console programs)
                \n      Inserts a new line (on Windows platforms)
                \r      Inserts a carriage return.
                \t      Inserts a horizontal tab into the string literal
            */
            Console.WriteLine("=> Escape characters");

            const string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            Console.WriteLine("Launcher finished.\n\n\n\a ");  // 4 blank lines then beep

            Console.WriteLine();
        }

        private static void VerbatimStrings()
        {
            Console.WriteLine("=> Verbatim strings");

            // The following string is printed verbatim thus, all escape characters are displayed
            Console.WriteLine(@"C:\MyApp\bin\Debug\n");

            // White space is preserved with verbatim strings.
            const string myLongString = @"This is a very
                 very
                      very
                           long string";
            Console.WriteLine(myLongString);

            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

            Console.WriteLine();
        }

        private static void StringEquality()
        {
            /*
                The string equality operators have been redefined to behave as if strings were value types.
                Therefore the C# equality operators (== and !=) compare:
                 - the value for value types and strings
                 - the memory address for reference types different from String
            */
            Console.WriteLine("=> String equality");

            const string s1 = "Hello!";
            const string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));

            Console.WriteLine();
        }

        private static void StringsAreImmutable()
        {
            Console.WriteLine("=> Strings are immutable");

            var s1 = "This is my string.";
            var upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}\ns1 = {1}", upperString, s1);

            var s2 = "Initial value of the s2 string";
            var s3 = s2;
            s2 = "New s2 string value";
            Console.WriteLine("s2 initial value = {0}\ns2 new value = {1}", s3, s2);

            Console.WriteLine();
        }

        private static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder");

            // Make a StringBuilder with an initial size of 256
            var sb = new StringBuilder("**** Fantastic Games ****", 256);

            sb.Append("\n")
              .AppendLine("Half Life")
              .AppendLine("Morrowind")
              .AppendLine("Deus Ex")
              .AppendLine("System Shock");

            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);

            Console.WriteLine();
        }
    }
}