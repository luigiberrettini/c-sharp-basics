using System;

namespace Examples.Encapsulation
{
    partial class ComplexEmployee
    {
        public void GiveBonus( float amount )
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

        public string GetName()
        {
            return empName;
        }

        public void SetName( string name )
        {
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
            set { empId = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
    }
}