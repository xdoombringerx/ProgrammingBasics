using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter integer n to see if it is prime");
        Console.Write("n=");
        int integerN = int.Parse(Console.ReadLine());
        bool isPrime;
        int count = 0;
        for (int i = 2; i < integerN; i++)
        {
            if (integerN % i != 0)
            {
                count++;
            }
        }
        isPrime = count + 2 == integerN ? true : false;
        Console.WriteLine(isPrime);
    }
}