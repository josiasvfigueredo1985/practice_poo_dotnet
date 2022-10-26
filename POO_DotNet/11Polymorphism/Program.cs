internal class Program
{
    private static void Main(string[] args)
    {
        // Instances
        Console.WriteLine("Intern");
        Tax objI = new Intern();
        objI.foodVoucher(1000.00);
        objI.transpVoucher(1000.00);
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Manager");
        Tax objM = new Manager();
        objM.foodVoucher(15000.00);
        objM.transpVoucher(15000.00);
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Attendant");
        Tax objA = new Manager();
        objA.foodVoucher(7000.00);
        objA.transpVoucher(7000.00);
    }
}