class LegalPerson : Default
{
    // Mandatory method
    public override void loanFee(double value)
    {
        System.Console.WriteLine($"Loan fee for legal person R$: {(value * 0.2)}");
    }

}