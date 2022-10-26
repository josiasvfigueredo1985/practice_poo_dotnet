internal class Program
{
    private static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Josias";// Send information
        Console.WriteLine(p.Name);// Return sent information
    }
}