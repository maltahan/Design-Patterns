using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // we cant do something like that because the method inside Shape Factory is not Static
            //IShape Circle Circle = ShapeFactory.getShape("Circle");

            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            IShape shape1 = shapeFactory.getShape("CIRCLE");

            //call draw method of Circle
            shape1.draw();

            //get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.getShape("RECTANGLE");

            //call draw method of Rectangle
            shape2.draw();

            //get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.getShape("SQUARE");

            //call draw method of circle
            shape3.draw();
        }
    }
}