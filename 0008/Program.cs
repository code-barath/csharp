using System;

namespace _0008
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            Console.WriteLine("Enter a value for the radius");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.141 * (radius * radius);
            Console.WriteLine("The area of circle is " + area);
        }
    }
}
