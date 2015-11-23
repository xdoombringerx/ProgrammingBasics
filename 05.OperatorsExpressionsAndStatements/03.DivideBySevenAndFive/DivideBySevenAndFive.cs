using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Please enter integer to see if it can be divided by 7 and 5 in the same time");
        int integerN = int.Parse(Console.ReadLine());
        bool isDivided = (integerN % 7 == 0 && integerN % 5 == 0);
        Console.WriteLine(isDivided);
    }
}