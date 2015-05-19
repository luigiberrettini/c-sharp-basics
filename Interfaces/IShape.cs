namespace Examples.Interfaces
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}