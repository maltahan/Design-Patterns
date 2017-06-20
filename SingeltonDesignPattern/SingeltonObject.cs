using System;

namespace SingeltonDesignPattern
{
    public class SingeltonObject
    {
        //create an object of SingleObject
        private static SingeltonObject instance = new SingeltonObject();

        public int Id { get; set; }

        public string Name { get; set; }

        //make the constructor private so that this class cannot be
        //instantiated
        private SingeltonObject() { }

        //Get the only object available
        public static SingeltonObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}