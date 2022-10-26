internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person obj = new Person();

        obj.selfPresent();
        obj.selfPresent("Josias");
        obj.selfPresent("Josias", 37);
    }
}