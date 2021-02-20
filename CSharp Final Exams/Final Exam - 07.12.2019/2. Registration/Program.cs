using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _2._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int countSuccessPass = 0;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"[U][$](?<username>[A-Z][a-z]{2,})[U][$][P][@][$](?<pass>[A-Za-z]{5,}\d{1,})[P][@][$]";

                Match match = Regex.Match(input, pattern);


                if (match.Success)
                {
                    countSuccessPass++;
                    string userName = match.Groups["username"].Value;
                    string pass = match.Groups["pass"].Value;

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {userName}, Password: {pass}");
                }

                else
                {
                    Console.WriteLine("Invalid username or password");
                }

            }

            Console.WriteLine($"Successful registrations: {countSuccessPass}");
        }
    }
}
