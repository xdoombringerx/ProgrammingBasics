using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter a weight: ");
        double weight = double.Parse(Console.ReadLine());
        double weightOnMoon = (weight * 17) / 100;
        Console.WriteLine("The weight of the Moon is {0}!", weightOnMoon);

    }
}
