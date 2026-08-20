public static class MultiplesOf3Or5
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to calculate the sum of all multiples of 3 or 5 below it:");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            int sum = CalculateSumOfMultiplesOf3Or5(input);
            Console.WriteLine($"The sum of all multiples of 3 or 5 below {input} is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    private static int CalculateSumOfMultiplesOf3Or5(int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}