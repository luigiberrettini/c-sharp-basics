using System;

namespace Examples.Interfaces
{
    public class ClonablePoint : ICloneable
    {
        public int X { private get; set; }

        private int Y { get; set; }

        public PointDescription Desc = new PointDescription();

        public ClonablePoint(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            Desc.PetName = petName;
        }

        public ClonablePoint(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }

        public ClonablePoint() { }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n", X, Y, Desc.PetName, Desc.PointId);
        }

        // Return a copy of the current object (we need to adjust for the PointDescription)
        public object Clone()
        {
            // Shallow copy
            var newClonablePoint = (ClonablePoint)MemberwiseClone();

            // Fill in the gaps
            var currentDesc = new PointDescription { PetName = Desc.PetName };
            newClonablePoint.Desc = currentDesc;

            return newClonablePoint;
        }
    }
}