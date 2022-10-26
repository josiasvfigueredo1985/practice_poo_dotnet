class Student
{
    // Attributes
    private double grade1, grade2;

    // Average grade calculation
    private double average()
    {
        return (grade1 + grade2) / 2;
    }
    // Message
    public void message()
    {
        // the protected variable it´s not being accesed by other class, its used exclusively by it´s class
        Console.WriteLine("Inform the first grade:");
        grade1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inform the seconf grade:");
        grade2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The average grade is {average()}");
    }
}