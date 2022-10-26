
internal class Program
{
    private static void Main(string[] args)
    {
        NaturalPerson nps = new NaturalPerson();
        nps.loanFee(1000);

        LegalPerson lps = new LegalPerson();
        lps.loanFee(1000);
    }
}