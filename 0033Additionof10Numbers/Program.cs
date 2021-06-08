using System;

namespace _0033Additionof10Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int i = 1, sum = 0;

            while(i<=10)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum of 1+2+...+10 = " + sum);
        }
    }
}
