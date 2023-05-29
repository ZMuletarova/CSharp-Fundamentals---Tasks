using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([$\|%])(?<tab>[A-Z]{1}[a-z]{2,})\1:\s[[](?<d1>\d+)]\|[[](?<d2>\d+)]\|[[](?<d3>\d+)]\|$";
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.Write($"{match.Groups["tab"].Value}: ");

                    char newCharOne = (char)(int.Parse(match.Groups["d1"].Value));
                    Console.Write(newCharOne);
                    char newCharTwo = (char)(int.Parse(match.Groups["d2"].Value));
                    Console.Write(newCharTwo);
                    char newCharThree = (char)(int.Parse(match.Groups["d3"].Value));
                    Console.WriteLine(newCharThree);
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
