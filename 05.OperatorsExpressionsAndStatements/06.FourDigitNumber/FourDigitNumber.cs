using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four-digit number");
        int integerN = int.Parse(Console.ReadLine());
        int thousandths = integerN / 1000;
        int hundreds = (integerN / 100) % 10;
        int tenths = (integerN / 10) % 10;
        int units = integerN % 10;
        Console.WriteLine("Sum of digits are {0}", thousandths + hundreds + tenths + units);
        Console.WriteLine("The number in reserved order is {0}", units * 1000 + tenths * 100 + hundreds * 10 + thousandths * 1);
        Console.WriteLine("The number with last digit in front is {0}", units * 1000 + tenths * 1 + hundreds * 10 + thousandths * 100);
        Console.WriteLine("The number with second and third digits exchanged {0}", units * 1 + tenths * 100 + hundreds * 10 + thousandths * 1000);
    }
}