using System;

namespace _0035EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int i = 0;
            int n;

            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

                while(i <= n)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
}
