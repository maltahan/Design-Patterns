using DesginPatternsDemos.AbstractFactory;
using DesginPatternsDemos.AbstractFactory.FactoryProcucer;
using DesginPatternsDemos.AbstractFactory.ShapeFactory;


namespace DesginPatternsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShapeFactory s = new ShapeFactory();

            //IShape circle = s.GetShape("Circle");

            //get shape factory
            AbstractFactory.AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

            //get an object of Shape Circle
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Shape Circle
            shape1.draw();

            //get an object of Shape Rectangle
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Shape Rectangle
            shape2.draw();

            //get an object of Shape Square 
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of Shape Square
            shape3.draw();

            //get color factory
            AbstractFactory.AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

            //get an object of Color Red
            IColor color1 = colorFactory.GetColor("RED");

            //call fill method of Red
            color1.fill();

            //get an object of Color Green
            IColor color2 = colorFactory.GetColor("Green");

            //call fill method of Green
            color2.fill();

            //get an object of Color Blue
            IColor color3 = colorFactory.GetColor("BLUE");

            //call fill method of Color Blue
            color3.fill();
        }
    }
}