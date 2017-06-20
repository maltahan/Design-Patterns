using System;

namespace SingeltonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            SingeltonObject SingeltonObj = SingeltonObject.getInstance();

            SingeltonObj.Id = 1;
            SingeltonObj.Name = "Mohammad";

            //show the message
            SingeltonObj.showMessage();

            //Get another but it takes the same values as the first one .

            SingeltonObject SingeltonObj1 = SingeltonObject.getInstance();

            Console.WriteLine(SingeltonObj.Id + "" + SingeltonObj.Name);

            Console.WriteLine(SingeltonObj1.Id + "" + SingeltonObj1.Name);
        }
    }
}