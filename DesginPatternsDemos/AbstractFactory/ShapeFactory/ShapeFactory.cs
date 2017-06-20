using System;

namespace DesginPatternsDemos.AbstractFactory.ShapeFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("CIRCLE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new Square();
            }

            return null;
        }
    }
}