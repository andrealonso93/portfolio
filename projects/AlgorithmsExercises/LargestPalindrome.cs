public static class LargestPalindrome
{
    public static void Run()
    {
        Console.WriteLine("A palindrome is a number that reads the same forwards and backwards. For example, 12321 is a palindrome.");
        Console.WriteLine("Enter a number of digits to find the largest palindrome made from the product of two numbers with that many digits.");
        if (int.TryParse(Console.ReadLine(), out int digits) && digits > 0)
        {
            long largestPalindrome = FindLargestPalindrome(digits);
            Console.WriteLine($"The largest palindrome made from the product of two {digits}-digit numbers is: {largestPalindrome}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    private static long FindLargestPalindrome(int digits)
    {
        long max = long.Parse(new string('9', digits));
        long min = long.Parse("1" + new string('0', digits - 1));
        long largestPalindrome = -1;

        for (long i = max; i >= min; i--)
        {
            if (largestPalindrome >= i * max)
                break;

            for (long j = max; j >= i; j--)
            {
                long product = i * j;
                if(largestPalindrome < product && product.IsPalindrome())
                    largestPalindrome = product;
            }
        }
        return largestPalindrome;
    }
}

public static class LongExtension
{
    public static bool IsPalindrome(this long number)
    {
        string str = number.ToString();
        var reversedStr = new string(str.Reverse().ToArray());
        return str == reversedStr;
    }
}
