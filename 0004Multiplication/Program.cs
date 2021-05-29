using System;

namespace _0004Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int result;

            Console.WriteLine("Enter a value for A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for B");
            b = Convert.ToInt32(Console.ReadLine());

            result = a * b;
            Console.WriteLine("Result is " + result);
        }
    }
}
