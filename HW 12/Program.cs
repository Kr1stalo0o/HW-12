
public static class FibonacciCalculator
{
    public static int GetFibonacci(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("The input number must be greater than 0.");
        }
        else if (n == 1)
        {
            return 0;
        }
        else if (n == 2)
        {
            return 1;
        }
        else
        {
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the ordinal number of the Fibonacci sequence:");

        int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"The Fibonacci number of order {input} is {GetFibonacci(input)}.");
    }
}
