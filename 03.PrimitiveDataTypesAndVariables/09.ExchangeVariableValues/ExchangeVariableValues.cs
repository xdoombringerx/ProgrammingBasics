using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\na={0}\nb={1}", a, b);
        int oldA = a;
        a = b;
        b = oldA;
        Console.WriteLine("After:\na={0}\nb={1}", a, b);

        //second solution
        /*
        a = 5;
        b = 10;
        Console.WriteLine("Before:\na={0}\nb={1}", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After:\na={0}\nb={1}", a, b);
         */
    }
}