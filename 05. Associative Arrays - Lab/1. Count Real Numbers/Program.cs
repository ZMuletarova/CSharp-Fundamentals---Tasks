using System;
using System.Linq;
using System.Collections.Generic;

namespace Dictionaries__Lambda_and_LINQ_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var countOfNumber = new SortedDictionary<int, int>();
            
            foreach (var number in numbers)
            {
                if (!countOfNumber.ContainsKey(number))
                {
                    countOfNumber[number] = 1;
                }
                else
                {
                    countOfNumber[number] += 1;
                }
            }

            foreach (var item in countOfNumber)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
