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
