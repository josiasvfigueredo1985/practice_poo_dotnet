// Collaborator inherite from Person to access its protected or public attributes and methods
class Collaborator : Person
{
    // Attributes
    private double salary;
    private string role;

    //Constructor
    public Collaborator(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
        messageCollaborator();
        messagePerson();
    }

    //Method
    private void messageCollaborator()
    {
        Console.WriteLine($"Salary: {salary}\n Role: {role}");
    }

}