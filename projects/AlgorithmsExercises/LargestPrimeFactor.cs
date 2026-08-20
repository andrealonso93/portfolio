public static class LargestPrimeFactor
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to calculate its largest prime factor:");
        if (long.TryParse(Console.ReadLine(), out long input))
        {
            long largestPrimeFactor = CalculateLargestPrimeFactor(input);
            Console.WriteLine($"The largest prime factor of {input} is: {largestPrimeFactor}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static long CalculateLargestPrimeFactor(long n)
    {
        if(n.IsPrime())
            return n;

        var factor = BiggerFactor(n);
        while(!factor.IsPrime())
        {
            factor = BiggerFactor(factor);
        }

        return factor;

        long BiggerFactor(long n)
        {
            if (n % 2 == 0)
                return n / 2;

            for (int i = 3; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return n / i;
            }
            return 0;
        }
    }
}

public static class PrimeExtension
{
    public static bool IsPrime(this long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (long i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}