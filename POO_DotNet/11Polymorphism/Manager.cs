class Manager : Tax
{
    // Method
    // override keyword to use the method from the class itself instead the inherited
    public override void foodVoucher(double salary)
    {
        Console.WriteLine($"Default Manager discount of food voucher R$:{(salary * 0.15)}");
    }
}