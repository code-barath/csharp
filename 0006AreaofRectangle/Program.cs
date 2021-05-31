using System;

namespace _0006AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double breadth;
            double area;

            Console.WriteLine("Enter the value for the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value for the breadth");
            breadth = Convert.ToDouble(Console.ReadLine());

            area = length * breadth;
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
