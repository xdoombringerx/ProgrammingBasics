using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter value a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value c: ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;

        Console.WriteLine("The sum is: {0}", sum);
    }
}