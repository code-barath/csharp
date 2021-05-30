using System;

namespace _0010
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int area;

            Console.WriteLine("Enter a value for the length");
            length = Convert.ToInt32(Console.ReadLine());

            area = (length * length);

            Console.WriteLine("THE value of the square is " + area);
        }
    }
}
