using System;

namespace DesginPatternsDemos.AbstractFactory.Color
{
    public class Green : IColor
    {
        public void fill()
        {
          Console.WriteLine("Inside Green::fill() method.");
        }
    }
}