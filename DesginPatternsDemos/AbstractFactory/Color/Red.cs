using System;

namespace DesginPatternsDemos.AbstractFactory.Color
{
    public class Red :IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}