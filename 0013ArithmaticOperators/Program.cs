using System;

namespace _0013ArithmaticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;
            


            Console.WriteLine("Enter a value for A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for B");
            b = Convert.ToDouble(Console.ReadLine());

            result = a + b;
            Console.WriteLine("A + B is " + result);
            result = a - b;
            Console.WriteLine("A - B is " + result);
            result = a * b;
            Console.WriteLine("A * B is  " + result);
            result = a / b;
            Console.WriteLine("A / B is " + result);
            result = a % b;
            Console.WriteLine("A % B is " + result);
        }
    }
}
