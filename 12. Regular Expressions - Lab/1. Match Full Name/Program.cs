using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
