using System;

namespace _0042DigitAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n;
            int sum = 0;
            int d;

            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());



          while(n > 0)
            {
               
                d = n % 10;
                sum = sum + d;
                n = n / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
