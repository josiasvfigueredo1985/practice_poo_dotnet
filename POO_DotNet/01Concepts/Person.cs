using System;

class Person
{
    //Atributes
    public string name;
    public int age;

    public void message()
    {
        Console.WriteLine($"Hi {name}, you are {age} years old!");
    }

}