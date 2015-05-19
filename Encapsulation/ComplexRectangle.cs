using System;

namespace Examples.Encapsulation
{
    public class ComplexRectangle
    {
        private ColoredPoint topLeft = new ColoredPoint();
        private ColoredPoint bottomRight = new ColoredPoint();

        public ColoredPoint TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public ColoredPoint BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]",
              topLeft.X, topLeft.Y, topLeft.Color,
              bottomRight.X, bottomRight.Y, bottomRight.Color);
        }
    }
}
