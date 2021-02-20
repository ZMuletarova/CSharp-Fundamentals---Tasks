using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _6._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s|^)(?<user>[A-Za-z0-9]+([-._]?[A-Za-z0-9])*)@(?<host>[A-Za-z](\-?[A-Za-z])*(\.[A-Za-z](\-?[A-Za-z])*)+)";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
