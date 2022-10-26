class Student
{
    //Attributes
    public string name;
    public double grade1, grade2;

    // Average
    public double average()
    {
        return (grade1 + grade2) / 2;
    }

    //Situation
    public string situation(double average)
    {
        // ternary operator
        return average >= 7 ? "approved" : "reproved";
    }

    //Message
    public void message()
    {
        // Obtain the average grade
        double obtainAverage = average();

        // Obtain the student situation
        string obtainSituation = situation(obtainAverage);

        Console.WriteLine($"{name}, you are {obtainSituation} with an average grade of {obtainAverage}");
    }
}