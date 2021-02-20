
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _4._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string newInput = string.Empty;
            var atackedPlanets = new Dictionary<string, int>();
            var destroyedPlanets = new Dictionary<string, int>();
            int count = 0;
            string regex = "S T A R s t a r";

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                newInput = string.Empty;
                count = 0;

                for (int k = 0; k < input.Length; k++)
                {
                    if (regex.Contains(input[k]))
                    {
                        count++;
                    }
                }

                for (int j = 0; j < input.Length; j++)
                {
                    string inputString = ((int)input[j] - count).ToString();
                    int numberInteger = int.Parse(inputString);
                    newInput += (char)(numberInteger);
                }

                string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*!(?<attack>A|D)![^@\-!:>]*->(?<soldiers>\d+)";
                Match match = Regex.Match(newInput, pattern);
                string namePlanet = match.Groups["planet"].Value;

                if (match.Groups["attack"].Value == "D")
                {
                    if (!destroyedPlanets.ContainsKey(namePlanet))
                    {
                        destroyedPlanets[namePlanet] = 1;
                    }

                    else
                    {
                        destroyedPlanets[namePlanet] += 1;
                    }
                }

                else if (match.Groups["attack"].Value == "A")
                {
                    if (!atackedPlanets.ContainsKey(namePlanet))
                    {
                        atackedPlanets[namePlanet] = 1;
                    }

                    else
                    {
                        atackedPlanets[namePlanet] += 1;
                    }
                }
            }

            var finalAtacked = atackedPlanets.OrderBy(x => x.Key).ToArray();
            var finalDestroyed = destroyedPlanets.OrderBy(x => x.Key).ToArray();

            Console.WriteLine($"Attacked planets: {finalAtacked.Length}");
            foreach (var allItemAtacked in finalAtacked)
            {
                Console.WriteLine($"-> {allItemAtacked.Key}");
            }

            Console.WriteLine($"Destroyed planets: {finalDestroyed.Length}");

            foreach (var allItemDestroyed in finalDestroyed)
            {
                Console.WriteLine($"-> {allItemDestroyed.Key}");
            }

        }
    }
}
