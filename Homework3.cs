Question1-Code
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
        if (N <= 1)
        {
            Console.WriteLine("Please enter a number greater than 1, 1 is not a prime number!");
        }
        else
        
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{N} is prime");
            }
            else
            {
                Console.WriteLine($"{N} is non-prime");
            }
        }

        Console.WriteLine(); 
    }
}
Question2-Code
