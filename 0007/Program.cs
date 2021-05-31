using System;

namespace _0007
{
    class Program
    {
        static void Main(string[] args)
        {
            double triHeight;
            double triBase;
            double triArea;

            Console.WriteLine("Enter the height of the triangle");
            triHeight  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for the base");
            triBase = Convert.ToDouble(Console.ReadLine());

            triArea = (triHeight * triBase) / 2;
            Console.WriteLine("Area of triangle is " + triArea);

        }
    }
}
