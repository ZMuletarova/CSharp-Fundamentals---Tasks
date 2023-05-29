using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["name"].Value}, The {match.Groups["title"].Value}");
                    string nameLenght = match.Groups["name"].Value;
                    Console.WriteLine($">> Strength: {nameLenght.Length}");
                    string armourLenght = match.Groups["title"].Value;
                    Console.WriteLine($">> Armour: {armourLenght.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
