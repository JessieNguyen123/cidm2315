Question 1-Code
namespace Homwork7;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer(101, "Alice", 28);
        Customer c2 = new Customer(102, "Bob", 30);
        c1.PrintInfo();
        c2.PrintInfo();
        c1.ChangeID(201);
        Console.WriteLine();
        c1.PrintInfo();
        Console.WriteLine();
        c1.CompareAge(c2);
    }
    class Customer
    {
        private int id;
        public string Name { get; }
        public int Age { get; }
        public Customer(int id, string name, int age)
        {
            this.id = id;
            Name = name;
            Age = age;
        }
        public void ChangeID(int newId) => id = newId;
        public void PrintInfo() => Console.WriteLine($"ID: {id}, Name: {Name}, Age: {Age}");
        public void CompareAge(Customer other)
        {
            if (Age > other.Age)
                Console.WriteLine($"{Name} is older than {other.Name}");
            else if (Age < other.Age)
                Console.WriteLine($"{other.Name} is older than {Name}");
            else
                Console.WriteLine($"{Name} and {other.Name} are the same age");
        }
    }
}
Question 2-Code
 Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);
        c1.PrintInfo();
        c2.PrintInfo();
        c1.ChangeID(220);
        c2.ChangeID(221);
        c1.PrintInfo();
        c2.PrintInfo();
        Console.WriteLine();
        c1.CompareAge(c2);
    }
    class Customer
    {
        private int id;
        public string Name { get; }
        public int Age { get; }
        public Customer(int id, string name, int age)
        {
            this.id = id;
            Name = name;
            Age = age;
        }
        public void ChangeID(int newId) => id = newId;
        public void PrintInfo() => Console.WriteLine($"Customer: {id}, Name: {Name}, Age: {Age}");
        public void CompareAge(Customer other)
        {
            if (Age > other.Age)
                Console.WriteLine($"{Name} is older than {other.Name}");
            else if (Age < other.Age)
                Console.WriteLine($"{other.Name} is older than {Name}");
            else
                Console.WriteLine($"{Name} and {other.Name} are the same age");
        }
