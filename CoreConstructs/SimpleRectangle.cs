using System;

namespace Examples.CoreConstructs
{
    public struct SimpleRectangle
    {
        // The structure contains a reference type member
        public readonly ShapeInfo RectInfo;
        private readonly int rectTop;
        private readonly int rectLeft;
        public int RectBottom;
        private readonly int rectRight;

        public SimpleRectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            rectTop = top; RectBottom = bottom;
            rectLeft = left; rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " + "Left = {3}, Right = {4}",
                RectInfo.InfoString, rectTop, RectBottom, rectLeft, rectRight);
        }
    }
}