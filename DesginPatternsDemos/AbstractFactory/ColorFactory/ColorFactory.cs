using DesginPatternsDemos.AbstractFactory.Color;
using System;

namespace DesginPatternsDemos.AbstractFactory.ColorFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }

            if (color.Equals("RED", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Red();

            }
            else if (color.Equals("GREEN",StringComparison.CurrentCultureIgnoreCase))
            {
                return new Green();

            }
            else if (color.Equals("BLUE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new Blue();
            }

            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            return null;//
        }
    }
}