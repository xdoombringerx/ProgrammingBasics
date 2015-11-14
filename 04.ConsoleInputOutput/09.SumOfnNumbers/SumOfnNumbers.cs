using System;

class SumOfnNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

