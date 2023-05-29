// See https://aka.ms/new-console-template for more information
class Student
{
    private string name;
    private int age;
    private double grade;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set {
            if (value < 18)
             {
                Console.WriteLine("Nevalidna vuzrast");
             }
                else
                {
                 age = value; 
                }
            }
    }
    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Grade: " + grade);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "John";
        student.Age = 20;
        student.Grade = 3.7;
        student.PrintDetails();

        student.Age = 12;

        Console.WriteLine(student.Age);
    }
}
