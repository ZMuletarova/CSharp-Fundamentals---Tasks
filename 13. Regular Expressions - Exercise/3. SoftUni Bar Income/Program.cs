using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"%(?<customer>[A-Z]{1}[a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<count>\d+)\|[^|$%\.]*?(?<price>\d+\.?\d+)\$";
            double totalIncome = 0;
            double finalTotalIncome = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                Match collections = Regex.Match(input, pattern);

                if (collections.Success)
                {
                    string name = collections.Groups["customer"].Value;
                    string product = collections.Groups["product"].Value;
                    int quantity = int.Parse(collections.Groups["count"].Value);
                    double price = double.Parse(collections.Groups["price"].Value);

                    totalIncome = quantity * price;
                    finalTotalIncome += totalIncome;

                    if (quantity != 0)
                    {
                        Console.WriteLine($"{name}: {product} - {totalIncome:f2}");
                    }
                }
            }
            Console.WriteLine($"Total income: {finalTotalIncome:f2}");
        }
    }
}
