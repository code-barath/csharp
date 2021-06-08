using System;

namespace _0017LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 10;
            b = 7;
            c = 3;

            Console.WriteLine("Is A bigger "+ (a > b && a > c));

            Console.WriteLine("Is A divisble by 5 or 2 " + (a%b == 0 || a%c == 0));

            Console.WriteLine("Is A divisble by B " + !(a%b == 0));
        }
    }
}
