using System;

namespace _0022PassOrFail
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string subject;
            int mark;

            Console.WriteLine("Enter your Name");
            name = Console.ReadLine();

            Console.WriteLine("Dear{0},Enter the subject and mark", name);
            subject = Console.ReadLine();
            mark = Convert.ToInt32(Console.ReadLine());

            if(mark >= 50)
            {
                Console.WriteLine("Dear {0},you have passed your {1}",name,subject);
            }
            else
            {
                Console.WriteLine("Dear {0},you have failed your {1}", name, subject);
            }

        }
    }
}
