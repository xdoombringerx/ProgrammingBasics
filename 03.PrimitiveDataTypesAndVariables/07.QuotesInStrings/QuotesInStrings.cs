using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstQuotedString = @"The ""use"" of quotations causes difficulties.";
        string secondQuotedString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstQuotedString);
        Console.WriteLine(secondQuotedString);
    }
}