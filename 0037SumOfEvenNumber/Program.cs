using System;

namespace _0037SumOfEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int i = 0;
            int n;
            int sum = 0;

            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

            while(i <= n)
            {
                
                sum = sum + i;
                i=i+2;
            }
            Console.WriteLine("The sum of all Even numbers in {0} is {1}",n,sum);
        }
    }
}
