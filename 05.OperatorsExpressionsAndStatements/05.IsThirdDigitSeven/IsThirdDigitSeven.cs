using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n to see if its third digit from right-to-left is 7");
        int integerN = int.Parse(Console.ReadLine());
        bool thirdDigit = (integerN / 100) % 10 == 7;
        Console.WriteLine(thirdDigit);
    }
}