abstract class Default
{
    // Mandatory method (can be public or protected)
    public abstract void loanFee(double value);

    // Optional method
    public void calculationLoanFee(double value, double fee)
    {
        System.Console.WriteLine($"Gains from savings R$: {(value * fee)}");
    }
}