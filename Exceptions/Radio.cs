using System;

namespace Examples.Exceptions
{
    public class Radio
    {
        private bool isOn;

        public void TurnOn(bool on)
        {
            isOn = on;
            Console.WriteLine(isOn ? "Jamming..." : "Quiet time...");
        }
    }
}