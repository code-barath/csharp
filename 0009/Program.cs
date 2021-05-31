using System;

namespace _0009
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            Console.WriteLine("Enter a value for the  radius");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 4 * 3.141 * (radius * radius);
            Console.WriteLine("Area of the sphere is " + area);
        }
    }
}
