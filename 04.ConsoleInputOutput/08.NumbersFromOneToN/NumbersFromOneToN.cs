using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers from 1 to {0} are:", n);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

