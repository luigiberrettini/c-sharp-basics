namespace Examples.CoreConstructs
{
    public class DatabaseReader
    {
        // Nullable data field
        private readonly int? numericValue = null;
        private readonly bool? boolValue = true;

        // Nullable return type
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        // Nullable return type
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}