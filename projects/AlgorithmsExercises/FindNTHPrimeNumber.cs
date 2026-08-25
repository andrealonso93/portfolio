public static class NthPrimeNumber
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to find the Nth prime number:");
        if (int.TryParse(Console.ReadLine(), out int n))
            Console.WriteLine($"The {n}th prime number is {FindNthPrime(n)}");
        else
            Console.WriteLine("Invalid input");
    }

    private static int FindNthPrime(int n)
    {
        int count = 0;
        int number = 1;
        while (count < n)
        {
            number++;
            if (IsPrime(number))
                count++;
        }
        return number;
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