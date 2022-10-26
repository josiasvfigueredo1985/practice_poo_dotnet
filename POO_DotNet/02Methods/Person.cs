using System;

class Person
{
    // Method 01
    public void selfPresent()
    {
        Console.WriteLine("Hello!");
    }
    // Method 02 - Its possible to create methods with the same name, as long its parameters be different 
    // in type and/or quantity from eachother
    public void selfPresent(string name)
    {
        Console.WriteLine($"Hello, {name}!");

    }
    // Method 03
    public void selfPresent(string name, int age)
    {
        Console.WriteLine($"Hello, {name}, you are {age} old!");
    }

}
