using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
    

namespace _2._Password
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            string pattern = @"^(.+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<four>[^<>]{3})<\1$";

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string one = match.Groups["first"].Value;
                    string second = match.Groups["second"].Value;
                    string third = match.Groups["third"].Value;
                    string four = match.Groups["four"].Value;

                    string final = one + second + third + four;
                    Console.WriteLine($"Password: {final}");
                }

                else
                {
                    Console.WriteLine("Try another password!");
                }
            }

        }
    }
}
