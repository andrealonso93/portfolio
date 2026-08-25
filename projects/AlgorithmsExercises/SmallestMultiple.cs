public static class SmallestMultiple
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to find the smallest multiple of all numbers from 1 to that number:");
        if (int.TryParse(Console.ReadLine(), out int n))
            Console.WriteLine($"Smallest multiple of 1 to {n} is {FindSmallestMultiple(n)}");
        else
            Console.WriteLine("Invalid input");

    }

    private static long FindSmallestMultiple(int n)
    {
        long smallest = n;
        while (!CheckIfMultipleByAllNumbers(smallest, n))
        {
            smallest++;
        }
        return smallest;
    }

    private static bool CheckIfMultipleByAllNumbers(long number, int n)
    {
        for (int i = n; i >= 2; i--)
        {
            if (number % i != 0)
                return false;
        }
        return true;
    }
}