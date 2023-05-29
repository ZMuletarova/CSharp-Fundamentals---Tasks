using System;
using System.Linq;
using System.Collections.Generic;


namespace _2._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    numbers[i] = numbers[i];
                    break;
                }
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count-1);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
