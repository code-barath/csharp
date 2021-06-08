using System;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;//variables

            Console.WriteLine("Enter a value for A");//value for a
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for B");//value for b
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for C");//value for c
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A value is : " + a);//entered A value
            Console.WriteLine("b value is : " + b);//entered B value
            Console.WriteLine("c value is : " + c);//entered C value

            if (a > b)//A greater than B
            {
                Console.WriteLine("A is greater than B");
                Console.WriteLine("----------------------------------");
            }
            if(a < b)//A lesser than B
            {
                Console.WriteLine("A is lower than B");
                Console.WriteLine("---------------------------------");
            }
            if(a > c)//A greater than C
            {
                Console.WriteLine("A is greater than c");
                Console.WriteLine("---------------------------------");
            }
            if(a < c)//A lesser than C
            {
                Console.WriteLine("A is lower than C");
                Console.WriteLine("---------------------------------");
            }



            if (b > a)// B greater than A
            {
                Console.WriteLine("B is greater than A");
                Console.WriteLine("---------------------------------");
            }
            if (b < a)// B lesser than A
            {
                Console.WriteLine("B is lower than A");
                Console.WriteLine("---------------------------------");
            }
            if (b > c)// B is greater than C
            {
                Console.WriteLine("B is greater than C");
                Console.WriteLine("---------------------------------");
            }
            if (b < c)// B is lesser than C
            {
                Console.WriteLine("B is lower than C");
                Console.WriteLine("---------------------------------");
            }


            if (c > a)// C is greater than A
            {
                Console.WriteLine("C is greater than A");
                Console.WriteLine("---------------------------------");
            }
            if (c < a)// C is lesser than A
            {
                Console.WriteLine("C is lower than A");
                Console.WriteLine("---------------------------------");
            }
            if (c > b)// C is greater than B
            {
                Console.WriteLine("C is greater than B");
                Console.WriteLine("---------------------------------");
            }
            if (c < b)// C is lesser than B
            {
                Console.WriteLine("C is lower than B");
                Console.WriteLine("---------------------------------");
            }

            if(a > b && a > c)// A greatest
            {
                Console.WriteLine("A IS THE GREATEST");
                Console.WriteLine("**********************************");
            }
            if(b > a && b > c)//B greatest
            {
                Console.WriteLine("B IS  THE GREATEST");
                Console.WriteLine("**********************************");
            }
            if(c > a && c > b)//c greatest
            {
                Console.WriteLine("C IS THE GREATEST");
                Console.WriteLine("**********************************");
            }
        }

   }
}
