using System;

class InsideCircleAndOutsideOfRectangle
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());

        const double r = 1.5d;
        double xCircle = x - 1;
        double yCircle = y - 1;


        bool insideCircle = ((xCircle * xCircle) + (yCircle * yCircle)) <= (r * r);
        bool insideRectangle = (-1 <= x && x <= 5) && (y <= 1);

        if (insideCircle == true && insideRectangle == false)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}