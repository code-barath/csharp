using System;

namespace _0018SimpleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a number");

            num = Convert.ToInt32(Console.ReadLine());

            if(num % 5 == 0)
            {
                Console.WriteLine("Number {0} is divisible by 5",num);
            }
        }
    }
}
