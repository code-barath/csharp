using System;

namespace _0019SimpleIf02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerator, denominator;

            Console.WriteLine("Enter a value for numerator");
            numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for denominator");
            denominator = Convert.ToDouble(Console.ReadLine());

            if (numerator % denominator == 0)
            {
                //Console.WriteLine("Numerator (" + numerator + ") is divisble by Denominator (" + denominator + ")");
                Console.WriteLine("Numerator({0}) is divisble by Denominator({1})", numerator, denominator);
            }
            else {
                Console.WriteLine("Numerator({0}) is not divisble by Denominator({1})", numerator, denominator);
            }
        }
    }
}
