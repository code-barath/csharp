using System;

namespace _0043MultiplicationOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int multiply = 1;
            int d;

            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());


            while(n >=1)
            {
                d = n % 10;
                multiply = multiply * d;
                n = n / 10;
            }

            Console.WriteLine("The product of the digits  is {0}",multiply);
        }
    }
}
     