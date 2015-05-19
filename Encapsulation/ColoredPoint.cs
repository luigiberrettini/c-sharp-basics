using System;

namespace Examples.Encapsulation
{
    public enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

    public class ColoredPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public ColoredPoint(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public ColoredPoint(PointColor ptColor)
        {
            Color = ptColor;
        }

        public ColoredPoint() : this(PointColor.BloodRed) { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("ColoredPoint is {0}", Color);
        }
    }
}
