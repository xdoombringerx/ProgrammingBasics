﻿using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Input n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary n:      {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        uint firstBits = (n >> 3) & 7;
        uint secondBits = (n >> 24) & 7;
        uint maskFirstBits = 7 << 3;
        uint maskSecondBits = 7 << 24;
        n = n & ~maskFirstBits | (secondBits << 3);
        n = n & ~maskSecondBits | (firstBits << 24);

        Console.WriteLine("Binary result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Result: {0}", n);
    }
}