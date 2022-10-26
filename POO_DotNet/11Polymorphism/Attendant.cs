class Attendant : Tax
{
     // Method
    public override void foodVoucher(double salary)
    {
        Console.WriteLine($"Default Attendant discount of food voucher R$:{(salary * 0.12)}");
    }
}