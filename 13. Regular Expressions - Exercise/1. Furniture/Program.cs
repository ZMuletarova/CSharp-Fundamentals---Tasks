using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Regular_Expressions_UPR
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\>>([A-Za-z]+)<<([0-9]+\.?\d*)!([0-9]+)";

            string input = Console.ReadLine();
            List<string> furnitures = new List<string>();
            decimal totalSpentMoney = 0;

            while (input!="Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    decimal price = decimal.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);
                    totalSpentMoney += price * quantity;

                    furnitures.Add(name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            for (int i = 0; i < furnitures.Count; i++)
            {
                Console.WriteLine(furnitures[i]);
            }

            Console.WriteLine($"Total money spend: {totalSpentMoney:f2}");
        }
    }
}
