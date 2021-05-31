using System;

namespace _0010
{
    class Program
    {
        static void Main(string[] args)
        {
            int side;
            int area;

            Console.WriteLine("Enter a value for side");
            side = Convert.ToInt32(Console.ReadLine());

            area = (side * side);

            Console.WriteLine("The area of the square is " + area);
        }
    }
}
