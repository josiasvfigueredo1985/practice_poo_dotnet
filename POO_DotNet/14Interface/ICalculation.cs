class ICalculation : IDefault, ITest
{
    // Calculation can implement many interfaces
public int n1;
public int n2;
    public void sum(int n1, int n2)
    {
        System.Console.WriteLine($"Sum result is: \n{n1 + n2}");
    }

    public void subtraction(int n1, int n2)
    {
        System.Console.WriteLine($"Subtraction result is: \n{n1 - n2}");
    }

    public int multiply()
    {
        return n1 * n2;
    }

    public bool validateCalculation()
    {
        if (multiply()<=0)
        {
            return false;
        }else
        {
            return true;
        }
    }

    public string messageValidation(){
        string message1 = "Valid number informed";
        string message2 = "Invalid number informed";
        if (validateCalculation())
        {
            return message1;
        }else
        {
            return message2;
        }
    }
}