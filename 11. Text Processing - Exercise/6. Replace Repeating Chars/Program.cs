using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string final = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (final.EndsWith(input[i]))
                {
                    continue;
                }
                else
                {
                    final += input[i];
                }
            }
            Console.WriteLine(final);
        }
    }
}
