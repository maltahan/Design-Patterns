using System;

namespace DesginPatternsDemos.AbstractFactory.FactoryProcucer
{
    public class FactoryProducer 
    {
        public static AbstractFactory getFactory(String choice)
        {

            if (choice.Equals("SHAPE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new ShapeFactory.ShapeFactory();

            }
            else if (choice.Equals("COLOR",StringComparison.CurrentCultureIgnoreCase))
            {
                return new ColorFactory.ColorFactory();
            }

            return null;
        }
    }
}