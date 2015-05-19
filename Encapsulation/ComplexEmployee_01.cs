namespace Examples.Encapsulation
{
    partial class ComplexEmployee
    {
        private string empName;
        private int empId;
        private float currPay;
        private int empAge;

        public ComplexEmployee()
        {
        }

        public ComplexEmployee(string name, int id, float pay) : this(name, 0, id, pay)
        {
        }

        private ComplexEmployee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
        }
    }
}