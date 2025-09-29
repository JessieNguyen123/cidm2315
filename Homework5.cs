Question1-Code
using System;

namespace Homework5
{
    class Program
    {
        static int GetLargestNumber()
        {
            Console.Write($"Enter value for (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Enter value for (b): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {a}; b = {b}");
            return ( a>b) ? a : b;
        }        
        static void Main(string[] args)
        {
            int largest = GetLargestNumber();
            Console.WriteLine($"The largest number is: {largest}");
        }
    
    }
}
Question2-Code
static int GetLargestNumber(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static int GetInteger(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int.TryParse(input, out int number);
            return number;
        }
        static int GetLargestofFour()
        {
            int a = GetInteger($"Enter value for (a): ");
            int b = GetInteger($"Enter value for (b): ");
            int c = GetInteger($"Enter value for (c): ");
            int d = GetInteger($"Enter value for (d): ");
            Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
            int max1 = GetLargestNumber(a, b);
            int max2 = GetLargestNumber(c, d);
            int max = GetLargestNumber(max1, max2);
            return max;
        }        
        static void Main(string[] args)
        {
            int largest = GetLargestofFour();
            Console.WriteLine($"The largest number is: {largest}");
        }
Question3-Code
{
    static void Main(string[]args)
    {
        createAccount();
    }
    static bool checkAge(int birth_year)
    {
        int current_year = 2025;
        int age = current_year - birth_year;
        return age >= 18;
    }
    static void createAccount()
    {
        Console.Write($"Enter username: ");
        string? username = Console.ReadLine();
        Console.Write("Enter password: ");
        string? password = Console.ReadLine();
        Console.Write("Re-enter password: ");
        string? confirmPassword = Console.ReadLine();
        Console.Write("Enter your birth year: ");
        string? input = Console.ReadLine();
        int.TryParse(input, out int birthYear);
        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine($"Account is created successfully");
            }
            else
            {
                Console.WriteLine($"Wrong password");
            }
        }
        else
        {
            Console.WriteLine($"Could not create an account");
        }
    }
    
    }
