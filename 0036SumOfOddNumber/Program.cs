using System;

namespace _0036SumOfOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int i=1;
            int n;
            int sum=0;

            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

            while(i< n)
            {
                //Console.WriteLine("The sum of Odd numbers is {0}" ,sum);

                sum = sum + i;
                i = i + 2;
            }

            Console.WriteLine("Sum = " + sum);


        }
    }
}
