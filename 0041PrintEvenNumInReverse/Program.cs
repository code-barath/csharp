using System;

namespace _0041PrintEvenNumInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            
            int n ;

            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

            while( n >= 0)
            {
                Console.WriteLine(n);
                n = n - 2;
            }
        }
    }
}
