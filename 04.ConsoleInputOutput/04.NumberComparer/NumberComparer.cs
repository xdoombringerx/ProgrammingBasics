using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double biggerNumber = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("Bigger number is: " + biggerNumber);
    }
}

