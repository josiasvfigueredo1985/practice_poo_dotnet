class NaturalPerson : Default
{
    // Mandatory method
    public override void loanFee(double value)
    {
       System.Console.WriteLine($"Loan fee for natural person R$: {(value*0.1)}");
    }
}