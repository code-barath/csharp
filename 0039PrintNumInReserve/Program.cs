using System;

namespace _0039PrintNumInReserve
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n; 


            Console.WriteLine("Enter a value for N");
            n = Convert.ToInt32(Console.ReadLine());

            while(n >= 0)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
