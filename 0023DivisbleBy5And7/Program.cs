using System;

namespace _0023DivisbleBy5And7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a value");
            number = Convert.ToInt32(Console.ReadLine());

            if(number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("{0}is both divisble by 5 and 7", number);
            }
            else
            {
                Console.WriteLine("{0} cannot be divided by either 5 or 7 or by both",number);
            }
        }
    }
}
