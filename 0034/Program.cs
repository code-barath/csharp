using System;

namespace _0034
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n;

            Console.WriteLine("Enter value of N: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i < n )
            {
                Console.WriteLine(i);
                i = i + 2;
            }
                
        }
    }
}
