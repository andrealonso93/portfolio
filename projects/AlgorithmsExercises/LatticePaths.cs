public static class LatticePaths
{
    public static void Run()
    {
        Console.WriteLine("Calculating the number of lattice paths in a 20x20 grid...");
        int gridSize = 20;
        ulong paths = CalculateLatticePaths(gridSize);
        Console.WriteLine($"The number of lattice paths in a {gridSize}x{gridSize} grid is {paths}");
    }

    private static ulong CalculateLatticePaths(int gridSize)
    {
        ulong allPossibilities = (ulong)gridSize * 2;
        ulong topFactorial = allPossibilities;
        for(ulong i = allPossibilities - 1; i > 1; i--)
        {
            topFactorial *= i;
        }

        ulong bottomFactorial = (ulong)gridSize;
        for(ulong i = (ulong)gridSize - 1; i > 1; i--)
        {
            bottomFactorial *= i;
        }
        ulong meuLongo= 17030314057236480000;
        return topFactorial / bottomFactorial * bottomFactorial;
    }
}