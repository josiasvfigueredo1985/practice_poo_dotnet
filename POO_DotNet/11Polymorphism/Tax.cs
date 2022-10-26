class Tax
{
    // Methods
    // "virtual" is the keyword to make the method possible to override
    public virtual void foodVoucher(double salary)
    {
        Console.WriteLine($"Default discount of food voucher R$:{(salary * 0.1)}");
    }

    public void transpVoucher(double salary)
    {
        Console.WriteLine($"Default discount of transportation voucher R$:{(salary * 0.6)}");
    }
}