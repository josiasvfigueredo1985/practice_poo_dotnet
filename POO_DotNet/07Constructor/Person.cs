class Person
{
    // Constructor - It´s possible to construct various objects as long its parameters be different in quantity and/or types
    public Person()
    {
        Console.WriteLine("Constructor executed!");
    }
    
    public Person(string name)
    {
        Console.WriteLine("Hello " + name+"!");
    }
}