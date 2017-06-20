using System;

namespace DesginPatternsDemos.AbstractFactory
{
    public class Circle : IShape
    {
        public void draw()
        {
           Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}