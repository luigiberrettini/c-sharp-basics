using System;

namespace Examples.CoreConstructs
{
    public struct SimplePoint
    {
        // Fields of the structure
        public int X;
        public int Y;

        // A custom constructor
        public SimplePoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        // Add 1 to the (X, Y) position
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}