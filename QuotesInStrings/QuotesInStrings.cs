using System;

    class QuotesInStrings
{
    static void Main()
    {
        string first = "The \"use\" of quotations causes difficulties.";
        string second = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("Example 1: {0}", first);
        Console.WriteLine("Example 2: {0}", second);
    }
}

