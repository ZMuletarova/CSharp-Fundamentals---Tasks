using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([0-9]{2})(-|.)([A-Za-z]{3})\2([0-9]{4})");

            MatchCollection dates = regex.Matches(input);

            foreach  (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}
