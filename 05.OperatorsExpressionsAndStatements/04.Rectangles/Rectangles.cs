using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter the width and height of rectangle to see its perimeter and area");
        Console.Write("width=");
        double widthRectangle = double.Parse(Console.ReadLine());
        Console.Write("height=");
        double heightRectangle = double.Parse(Console.ReadLine());
        double perimeter = (widthRectangle + heightRectangle) * 2;
        double area = widthRectangle * heightRectangle;
        Console.WriteLine("The perimeter of rectangle is {0}", perimeter);
        Console.WriteLine("The prea of rectangle is {0}", area);
    }
}