using System;

namespace _0015DecOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = 10;

            //Console.WriteLine("Value of A before decrement " + a);
            //a--;
            //Console.WriteLine("Value of A after decrement " + a);

            Console.WriteLine("Value of a is " + a--);
            Console.WriteLine("Value of a is " + --a);

            a -= 10; //a = a-10;
            Console.WriteLine("value of a is " + a);
        }
    }
}
