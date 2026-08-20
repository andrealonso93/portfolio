public static class FibonacciEvenSum
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to calculate the sum of even Fibonacci numbers that do not exceed it:");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            long sum = CalculateFibonacciEvenSum(input);
            Console.WriteLine($"The sum of even Fibonacci numbers that do not exceed {input} is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    private static long CalculateFibonacciEvenSum(int n)
    {
        int previous = 1;
        int current = 1;
        long evenSum = 0;
        while (current <= n)
        {
            if (current % 2 == 0)
                evenSum += current;

            var newPrevious = current;
            current += previous;
            previous = newPrevious;
        }
        return evenSum;
    }

}