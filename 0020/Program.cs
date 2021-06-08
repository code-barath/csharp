using System;

namespace _0020
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;

            Console.WriteLine("Enter you name");
            name = Console.ReadLine();
            Console.WriteLine("Dear {0},enter your age pls", name);
            age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("Dear {0}, you are eligble for NS", name);
            }
            else
            {
                Console.WriteLine("Dear {0}, you are not eligble for NS", name);
            }
        }
    }
}
