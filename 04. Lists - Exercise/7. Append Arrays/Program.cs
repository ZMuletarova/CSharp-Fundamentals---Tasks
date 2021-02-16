using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|").ToList();
            List<string> result = new List<string>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                string[] num = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < num.Length; j++)
                {
                    result.Add(num[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
