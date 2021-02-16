using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < number; i++)
            {
                names.Add(Console.ReadLine());
            }

            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i+1}.{names[i]}");
            }
        }
    }
}
