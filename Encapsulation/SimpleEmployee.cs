using System;

namespace Examples.Encapsulation
{
    public class SimpleEmployee
    {
        /*
            public               Types or type members            Public items have no access restrictions
                                                                  A public member can be accessed from an object, as well as any derived class
                                                                  A public type can be accessed from other external assemblies
                                 
            private               Type members or nested types    Private items can only be accessed by the class (or structure) that defines the item
                                  
            protected             Type members or nested types    Protected items can be used by the class which defines it and any child class
                                                                  They cannot be accessed from the outside world using the C# dot operator
                                  
            internal              Types or type members           Internal items are accessible only within the current assembly: a set of internal
                                                                  types within a .NET class library is not accessible by other assemblies
                                  
            protected internal    Type members or nested types    When the protected and internal keywords are combined on an item, the item is accessible
                                                                  within the defining assembly, the defining class and by derived classes

            Type members are implicitly private
            Types are implicitly internal
        */

        // Field data
        private string empName;
        private int empId;
        private float currPay;
        private int empAge;

        public SimpleEmployee()
        {
        }

        public SimpleEmployee(string name, int id, float pay)
            : this(name, 0, id, pay)
        {
        }

        private SimpleEmployee(string name, int age, int id, float pay)
        {
            // Use properties when setting class data: this reduces the amount of duplicate error checks
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
        }

        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }

        // Accessor (get method)
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method)
        public void SetName(string name)
        {
            // Do a check on incoming value before making assignment
            if (name.Length > 15)
                Console.WriteLine("Error!  Name must be less than 15 characters!");
            else
                empName = name;
        }

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        public int Id
        {
            get { return empId; }
            set { empId = value + 1; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value - 1; }
        }
    }
}