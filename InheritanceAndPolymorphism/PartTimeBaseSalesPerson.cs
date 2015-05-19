namespace Examples.InheritanceAndPolymorphism
{
    public sealed class PartTimeBaseSalesPerson : BaseSalesPerson
    {
        public PartTimeBaseSalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empId, currPay, ssn, numbOfSales)
        {
        }

        // Compiler error: cannot override this method as it was sealed
        //public override void GiveBonus( float amount )
        //{
        //}
    }
}