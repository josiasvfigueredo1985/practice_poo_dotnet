using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancing an object of Person type
            Person obj = new Person();
            //accessing the name attribute from Person class and attribuing a value
            obj.name = "Josias";
            //same here
            obj.age = 37;
            // calling the message method
            obj.message();
        }
    }
}