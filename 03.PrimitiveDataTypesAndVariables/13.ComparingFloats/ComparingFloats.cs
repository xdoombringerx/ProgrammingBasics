using System;

class ComparingFloats
{
    static void Main()
    {
        double first = 5.00000001;
        double second = 5.00000003;
        Console.WriteLine("Equal: {0}", GetEqualResult(first, second));

        first = 4.999999;
        second = 4.999998;
        Console.WriteLine("Equal: {0}", GetEqualResult(first, second));

        first = 5.3;
        second = 6.01;
        Console.WriteLine("Equal: {0}", GetEqualResult(first, second));

        first = -0.0000007;
        second = 0.00000007;
        Console.WriteLine("Equal: {0}", GetEqualResult(first, second));
    }

    static bool GetEqualResult(double firstValue, double secondValue)
    {
        double eps = 0.000001;

        double difference = Math.Abs(firstValue - secondValue);

        if (difference <= eps)
        {
            return true;
        }

        return false;
    }
}