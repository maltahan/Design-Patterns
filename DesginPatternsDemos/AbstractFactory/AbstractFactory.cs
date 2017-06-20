using System;

namespace DesginPatternsDemos.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(String color);

        
        public abstract IShape GetShape(String shape);
    }
}