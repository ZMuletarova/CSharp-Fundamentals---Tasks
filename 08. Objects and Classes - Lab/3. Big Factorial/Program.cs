using System;
using System.Numerics;


namespace _3._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger bigInteger = 1;

            for (int i = 1; i <= number; i++)
            {
                bigInteger *= i;
            }

            Console.WriteLine(bigInteger);
        }
    }
}
