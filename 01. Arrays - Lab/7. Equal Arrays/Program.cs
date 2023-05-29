using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int sumArrays = 0;
            int counterEqual = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    counter = i;
                    break;
                }
                else
                {
                    sumArrays += firstArray[i];
                    counterEqual++;
                }
            }

            if (counterEqual==firstArray.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumArrays}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {counter} index");
            }
        }
    }
}
