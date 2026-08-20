public static class CheckBalancedString
{
    public static void Run()
    {
        Console.WriteLine("Enter a string to check if it is balanced:");
        Console.WriteLine("A string is considered balanced if all opening characters have a corresponding closing character in the correct order.");
        Console.WriteLine("Valid opening characters are: '(', '{', '[' and their corresponding closing characters are: ')', '}', ']'.");
        string input = Console.ReadLine() ?? string.Empty;
        bool isBalanced = IsBalanced(input);
        Console.WriteLine(isBalanced ? "Balanced" : "Unbalanced");
    }
    private static bool IsBalanced(string s)
    {
        var opennedCharsStack = new Stack<char>();
        foreach (char c in s)
        {
            if (opennedCharsStack.Count == 0)
            {
                if (c.IsOpenningChar())
                    opennedCharsStack.Push(c);
                else
                    return false;
            }
            else
            {
                var lastOpennedChar = opennedCharsStack.Peek();
                if (c == lastOpennedChar.GetClosingChar())
                {
                    opennedCharsStack.Pop();
                }
                else if (c.IsOpenningChar())
                {
                    opennedCharsStack.Push(c);
                }
                else
                {
                    return false;
                }   
            }
        }

        return opennedCharsStack.Count == 0;
    }
}

public static class CharExtensions
{
    public static bool IsOpenningChar(this char c)
    {
        return c == '(' || c == '{' || c == '[';
    }

    public static char GetClosingChar(this char c)
    {
        return c switch
        {
            '(' => ')',
            '{' => '}',
            '[' => ']',
            _ => throw new ArgumentException("Invalid opening character")
        };
    }
}