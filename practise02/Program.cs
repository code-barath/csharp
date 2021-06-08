using System;

namespace practise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nation,second;
            double amount;

            Console.WriteLine("Enter your choice of country ");
            Console.WriteLine("1(Canada)2(Singapore)3(United states of America)4(India)");
            nation = Convert.ToInt32(Console.ReadLine());

            if(nation == 1)
            {
                Console.WriteLine("You have chosen Canada");
                Console.WriteLine("Enter amount");
                amount = Convert.ToDouble(Console.ReadLine());
            }

            if (nation == 2)
            {
                Console.WriteLine("You have chosen Singapore");
                Console.WriteLine("Enter amount");
                amount = Convert.ToDouble(Console.ReadLine());
            }

            if (nation == 3)
            {
                Console.WriteLine("You have chosen USA");
                Console.WriteLine("Enter amount");
                amount = Convert.ToDouble(Console.ReadLine());
            }

            if (nation == 1)
            {
                Console.WriteLine("You have chosen Canada");
                Console.WriteLine("Enter amount");
                amount = Convert.ToDouble(Console.ReadLine());
            }

        }
    }
}
