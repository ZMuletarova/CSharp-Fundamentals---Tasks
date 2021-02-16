using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Largest_3_Numbers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
