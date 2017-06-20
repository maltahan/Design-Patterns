using System;

namespace DesginPatternsDemos.AbstractFactory.Color
{
    public class Blue : IColor
    {
        public void fill()
        {
           Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}