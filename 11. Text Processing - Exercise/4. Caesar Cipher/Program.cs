using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _4._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char[] current = input[i].ToCharArray();

                for (int j = 0; j < current.Length; j++)
                {
                    output += (char)(current[j] + 3);
                }

                if (i==input.Length-1)

                {
                    break;
                }
                output += (char)(35);
            }
            Console.WriteLine(output);
        }
    }
}
