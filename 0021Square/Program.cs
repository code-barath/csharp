using System;

namespace _0021Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, breadth;

            Console.WriteLine("Enter the length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToInt32(Console.ReadLine());

            if(length == breadth)
            {
                Console.WriteLine("It is a square");
            }
            else
            {
                Console.WriteLine("It is not a square");
            }
        }
    }
}
