class Person
{
    //Attribute
    private string name = "Jimmy";
    public Person(string name)
    {
        // "This" command reffers to the attribute inside the class, instead the parameter from method
        Console.WriteLine($"'This' call parameter: {this.name}\nMethod call parameter: {name}");
    }

}