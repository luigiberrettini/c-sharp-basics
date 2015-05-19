using System;

namespace Examples.InheritanceAndPolymorphism
{
    public abstract class BaseEmployee
    {
        // BenefitPackage nests BenefitPackageLevel
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        // Field data
        private string empName;

        protected BaseEmployee()
        {
            Benefits = new BenefitPackage();
        }

        protected BaseEmployee(string name, int id, float pay)
            : this(name, 0, id, pay, "")
        {
        }

        protected BaseEmployee(string name, int age, int id, float pay, string ssn)
        {
            // Use properties when setting class data: this reduces the amount of duplicate error checks
            Benefits = new BenefitPackage();
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SocialSecurityNumber = ssn;
        }

        // Expose certain benefit behaviors
        public double GetBenefitCost()
        {
            return Benefits.ComputePayDeduction();
        }

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
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
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties
        public int Id { get; set; }

        public float Pay { get; set; }

        public int Age { get; set; }

        public string SocialSecurityNumber { get; set; }

        // Expose object through a custom property
        public BenefitPackage Benefits { get; set; }
    }
}