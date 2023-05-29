using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _5._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^[0-9+\-*\/.]";
            Regex regexHealth = new Regex(healthPattern);

            string digitPattern = @"-?\d+\.?\d*";
            Regex regexDigit = new Regex(digitPattern);

            string operatorPattern = @"[*|\/]";
            Regex regexOperator = new Regex(operatorPattern);

            string[] demonNames = Regex.Split(Console.ReadLine(), @"\s*,\s*").OrderBy(x => x).ToArray();

            for (int i = 0; i < demonNames.Length; i++)
            {
                string currentDemon = demonNames[i];
                int currentHealth = 0;

                MatchCollection healthSymbol = regexHealth.Matches(currentDemon);

                foreach (Match item in healthSymbol)
                {
                    currentHealth += char.Parse(item.Value);
                }

                MatchCollection digitMatch = regexDigit.Matches(currentDemon);

                double baseDamage = 0;

                foreach (Match item in digitMatch)
                {
                    baseDamage += double.Parse(item.Value);
                }

                MatchCollection operatorMatch = regexOperator.Matches(currentDemon);

                foreach (Match item in operatorMatch)
                {
                    string operatorM = item.Value;

                    if (operatorM == "*")
                    {
                        baseDamage *= 2;

                    }
                    else
                    {
                        baseDamage /= 2;
                    }
                }
                Console.WriteLine($"{currentDemon} - {currentHealth} health, {baseDamage:f2} damage");
            }
        }
    }
}
