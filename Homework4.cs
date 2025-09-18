Question1-Code
namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int largest = GetLargestNumber(a, b);
        Console.WriteLine($"a={a}; b={b}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine();
    }
    static int GetLargestNumber(int num1, int num2)
    {
        return (num1 > num2 ? num1 : num2);
    }
}
Question2-Code
        int N = 5;
        Console.WriteLine($"N is: {N}; shape is left");
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(new string('*', i));
        }
        Console.WriteLine();
        Console.WriteLine($"N is: {N}; shape is right");
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(new string(' ', N - i) + new string('*', i));
        }
        Console.WriteLine();
