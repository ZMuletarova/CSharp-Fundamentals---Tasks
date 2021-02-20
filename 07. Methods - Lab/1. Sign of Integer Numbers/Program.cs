using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void printNumbers()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }

            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }

            else if (a == 0)
            {
                Console.WriteLine($"The number {a} is zero.");
            }
        }


        static void Main(string[] args)
        {
            printNumbers();
        }

    }
}
