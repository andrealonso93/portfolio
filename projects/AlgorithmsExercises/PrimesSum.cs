public static class PrimesSum
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to find the sum of all prime numbers below that number:");
        if (int.TryParse(Console.ReadLine(), out int n))
            Console.WriteLine($"The sum of all prime numbers below {n} is {FindSumOfPrimesBelow(n)}");
        else
            Console.WriteLine("Invalid input");
    }

    private static int FindSumOfPrimesBelow(int n)
    {
        int sum = 0;
        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i))
                sum += i;
        }
        return sum;
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
