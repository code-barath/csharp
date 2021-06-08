using System;

namespace _0038MultiplicationOf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int i = 1;
            int n;
            int multiply = 1;
            
            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                multiply = multiply * i;
                i++;
            }
            Console.WriteLine(multiply);
        }
    }
}
