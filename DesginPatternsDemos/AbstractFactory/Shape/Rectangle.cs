using System;

namespace DesginPatternsDemos.AbstractFactory
{
    public class Rectangle : IShape
    {
        public void draw()
        {
          Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}