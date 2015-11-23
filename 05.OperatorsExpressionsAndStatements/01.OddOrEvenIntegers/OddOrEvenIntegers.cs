using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Number: ");
        int theNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((theNumber % 2 == 0) ? false : true); 
    }
}