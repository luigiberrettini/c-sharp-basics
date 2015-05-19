using System;

namespace Examples.CoreConstructs
{
    public static class FunWithEnums
    {
        enum EmpType //: byte
        {
            Manager,       // = 0
            Grunt,         // = 1
            Contractor,    // = 2
            VicePresident  // = 3
        }

        public static void Go()
        {
            Console.WriteLine("**** Fun with Enums *****");

            const EmpType emp = EmpType.Contractor;
            AskForBonusWithEnumParam(emp);

            // Prints out "emp is a Contractor"
            Console.WriteLine("emp is a {0}.", emp.ToString());

            // Prints out "Contractor = 100"
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);

            const EmpType e2 = EmpType.Contractor;

            // These types are enums in the System namespace
            const DayOfWeek day = DayOfWeek.Monday;
            const ConsoleColor cc = ConsoleColor.Gray;
            PrintEnumInfo(e2);
            PrintEnumInfo(day);
            PrintEnumInfo(cc);

            Console.ReadLine();
        }

        private static void AskForBonusWithEnumParam(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }

        private static void PrintEnumInfo(Enum e)
        {
            Console.WriteLine("=> Information about an enum");

            var enumType = e.GetType();
            var enumData = Enum.GetValues(enumType);

            Console.WriteLine("Name: {0}", enumType.Name);
            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(enumType));
            Console.WriteLine("This enum has {0} members", enumData.Length);
            for (var i = 0; i < enumData.Length; i++)
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));

            Console.WriteLine();
        }
    }
}