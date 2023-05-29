using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToList();

            foreach (var item in fruits)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
    }
}
