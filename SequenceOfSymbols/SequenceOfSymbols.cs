class SequenceOfSymbols
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No sequence of symbols provided.");
            return;
        }

        foreach (string symbols in args)
        {
            int number = GetNumberOfSymbols(symbols);
            Console.WriteLine($"Maximum number of unequal consecutive characters in '{symbols}' per line is {number}");
        }
    }

    static int GetNumberOfSymbols(string symbols)
    {
        if (string.IsNullOrEmpty(symbols))
            return 0;

        int number = 0;
        int currentNumber = 0;

        for (int i = 1; i < symbols.Length; i++)
        {
            if (symbols[i] != symbols[i - 1])
                currentNumber++;
            else
            {
                number = Math.Max(number, currentNumber);
                currentNumber = 0;
            }
        }

        return Math.Max(number, currentNumber);
    }
}
