namespace Examples.Encapsulation
{
    public static class MyMathClass
    {
        // public const double PI = 3.14;
        public static readonly double Pi;

        static MyMathClass()
        {
            Pi = 3.14;
        }
    }
}