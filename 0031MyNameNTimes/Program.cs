using System;

namespace _0031MyNameNTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n;
            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

          while(i <= n)
            {
                Console.WriteLine(i+". Barath");
                i++;
            }

             Console.WriteLine("Loop finished");

        }
    }
}
