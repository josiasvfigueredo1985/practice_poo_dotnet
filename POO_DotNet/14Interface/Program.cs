internal class Program
{
    private static void Main(string[] args)
    {
        ICalculation i = new ICalculation();
        i.sum(6, 2);
        i.subtraction(45, 6);

        i.n1 = 2;
        i.n2 = 10;
        Console.WriteLine(i.multiply());
        Console.WriteLine(i.validateCalculation());
        Console.WriteLine(i.messageValidation());
    }
}