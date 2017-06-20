using System;

namespace DesginPatternsDemos.AbstractFactory.Color
{
    public class Red :IColor
    {
   
        public void fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}