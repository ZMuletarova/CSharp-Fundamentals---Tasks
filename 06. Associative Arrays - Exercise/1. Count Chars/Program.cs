using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Associative_Arrays_UPR
{
    class Program
    {
        static void Main(string[] args)
        {
            var hystogram = new Dictionary<char, int>();
            string text = Console.ReadLine();
            char[] charText = text.ToCharArray();

            for (int i = 0; i < charText.Length; i++)
            {
                char current = text[i];
                if (current != ' ')
                {
                    if (!hystogram.ContainsKey(current))
                    {
                        hystogram[current] = 0;
                    }
                    hystogram[current]++;
                }
            }

            foreach (var item in hystogram)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
