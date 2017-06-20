using System;

namespace DesginPatternsDemos.AbstractFactory
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}