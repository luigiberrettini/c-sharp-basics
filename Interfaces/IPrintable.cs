namespace Examples.Interfaces
{
    interface IPrintable
    {
        void Print();

        // Possible name clash here
        void Draw();
    }
}