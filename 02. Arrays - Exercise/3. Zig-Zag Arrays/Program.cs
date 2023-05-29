using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstArray = new int[n];
            var secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2==0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
