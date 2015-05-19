namespace Examples.Interfaces
{
    // This interface defines the behavior of "having points"
    public interface IPointy
    {
        // A read-write property in an interface
        // retType PropName { get; set; }

        // A write-only property in an interface
        // retType PropName { set; }

        byte Points { get; }

        // Implicitly public and abstract
        //byte GetNumberOfPoints();
    }
}