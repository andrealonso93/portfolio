public static class TwoThousandthSecondSquareOddSum
{

    public static void Run()
    {
        Console.WriteLine("Finding the 202,000th square number and calculating the sum of all odd square numbers below it...");
        int squareCount = 0;
        double n = 1;
        double squareOddsSum = 0;
        while (squareCount < 202000)
        {
            double square = n * n;
            squareCount++;
            if (square.IsOdd())
                squareOddsSum += square;
            n++;
        }

        Console.WriteLine($"The 202,000th square number is {n - 1}");
        Console.WriteLine($"The sum of the square odds among the first 202000 square numbers is {squareOddsSum}");
    }


    private static bool IsOdd(this double number)
    {
        return (number % 2) != 0;
    }
}