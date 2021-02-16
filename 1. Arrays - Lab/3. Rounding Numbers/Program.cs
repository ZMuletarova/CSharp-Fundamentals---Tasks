using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];

                double roundedNumber = Math.Round(number, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{number} => {roundedNumber}");
            }
        }
    }
}
