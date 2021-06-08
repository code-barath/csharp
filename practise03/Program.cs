using System;

namespace practise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int nu;
            int num;

            Console.WriteLine("Enter the first digit");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second digit");
            nu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third digit");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered is {0}{1}{2}", n, nu, num);
            Console.WriteLine("When the number is reveresed it is {0}{1}{2}", num, nu, n);
        }
    }
}
