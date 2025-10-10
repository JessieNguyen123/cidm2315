Question1-Code
namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor("Alice", "Java", 9000);
        Professor p2 = new Professor("Bob", "Math", 8000);
        Student s1 = new Student("Lisa", "Java", 90);
        Student s2 = new Student("Tom", "Math", 80);
        Console.WriteLine("Professors: ");
        Console.WriteLine($"{p1.Name} teaches {p1.Course} and earns ${p1.GetSalary()}");
        Console.WriteLine($"{p2.Name} teaches {p2.Course} and earns ${p2.GetSalary()}");
        Console.WriteLine("\nStudents: ");
        Console.WriteLine($"{s1.Name} is enrolled in {s1.Course} and has a grade of {s1.GetGrade()}");
        Console.WriteLine($"{s2.Name} is enrolled in {s2.Course} and has a grade of {s2.GetGrade()}");
    }
}
class Professor
{
    private double salary;
    public string Name { get; }
    public string Course { get; }
    public Professor(string name, string course, double salary)
    {
        Name = name;
        Course = course;
        this.salary = salary;
    }
    public void SetSalary(double amount) => salary = amount;
    public double GetSalary() => salary;
}
class Student
{
    private double grade;
    public string Name { get; }
    public string Course { get; }
    public Student(string name, string course, double grade)
    {
        Name = name;
        Course = course;
        this.grade = grade;
    }
    public void SetGrade(double newGrade) => grade = newGrade;
    public double GetGrade() => grade;
}
Question2-Code
 static void Main(string[] args)
    {
        Professor p1 = new Professor("Alice", "Java", 9000);
        Professor p2 = new Professor("Bob", "Math", 8000);
        Student s1 = new Student("Lisa", "Java", 90);
        Student s2 = new Student("Tom", "Math", 80);
        Console.WriteLine($"Professor {p1.Name} teaches {p1.Course}, and the salary is: ${p1.GetSalary()}");
        Console.WriteLine($"Professor {p2.Name} teaches {p2.Course}, and the salary is: ${p2.GetSalary()}");
        Console.WriteLine($"Student {s1.Name} enrolled in {s1.Course}, and the grade is: {s1.GetGrade()}");
        Console.WriteLine($"Student {s2.Name} enrolled in {s2.Course}, and the grade is: {s2.GetGrade()}");
        double salaryDiff = p1.GetSalary() - p2.GetSalary();
        double totalGrade = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The salary difference between {p1.Name} and {p2.Name} is: {salaryDiff}");
        Console.WriteLine($"The total grade of {s1.Name} and {s2.Name} is: {totalGrade}");
    }
}
class Professor
{
    private double salary;
    public string Name { get; }
    public string Course { get; }
    public Professor(string name, string course, double salary)
    {
        Name = name;
        Course = course;
        this.salary = salary;
    }
    public void SetSalary(double amount) => salary = amount;
    public double GetSalary() => salary;
}
class Student
{
    private double grade;
    public string Name { get; }
    public string Course { get; }
    public Student(string name, string course, double grade)
    {
        Name = name;
        Course = course;
        this.grade = grade;
    }
    public void SetGrade(double newGrade) => grade = newGrade;
    public double GetGrade() => grade;
}
