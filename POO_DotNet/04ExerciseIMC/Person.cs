class Person
{
    public double height;
    public double weight;

    public double calculateBMI()
    {
        return weight / (height * height);
    }

    public string situation(double _bmi)
    {
        string[] situation = { "underweight", "normal weight", "overweitgh", "obesity 1", "obesity 2", "obesity 3" };
        int i = 0;
        double bmi = calculateBMI();

        if (bmi < 18.5)
        {
            i = 0;
        }
        else if (bmi < 25)
        {
            i = 1;
        }
        else if (bmi < 30)
        {
            i = 2;
        }
        else if (bmi < 35)
        {
            i = 3;
        }
        else if (bmi < 40)
        {
            i = 4;
        }
        else
        {
            i = 5;
        }
        return situation[i];
    }

    private double roundBMI(double bmi)
    {
        double r = Math.Round(bmi, 2, MidpointRounding.ToEven);
        return r;
    }
    public void message()
    {
        double bmi = roundBMI(calculateBMI());
        string obtainBmi = situation(bmi);
        Console.WriteLine($"Your BMI is {bmi} and your situation is:\n {obtainBmi}");
    }
}