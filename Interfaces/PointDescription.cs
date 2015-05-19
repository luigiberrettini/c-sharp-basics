using System;

namespace Examples.Interfaces
{
    public class PointDescription
    {
        public string PetName { get; set; }

        public Guid PointId { get; private set; }

        public PointDescription()
        {
            PetName = "No-name";
            PointId = Guid.NewGuid();
        }
    }
}