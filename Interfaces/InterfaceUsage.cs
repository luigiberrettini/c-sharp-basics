using System;

namespace Examples.Interfaces
{
    public static class InterfaceUsage
    {
        public static void Go()
        {
            Console.WriteLine("***** A first look at interfaces *****\n");

            const string myStr = "Hello";
            var unixOs = new OperatingSystem(PlatformID.Unix, new Version());
            var sqlCnn = new System.Data.SqlClient.SqlConnection();

            // The above classes support the ICloneable interface, therefore they can be passed into a method taking ICloneable
            CloneMe(myStr);
            CloneMe(unixOs);
            CloneMe(sqlCnn);

            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            // Clone whatever we get and print out the name
            var theClone = c.Clone();
            Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
        }
    }
}