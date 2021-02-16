using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsQuantity = new Dictionary<string, int>();
            var productsAllPrice = new Dictionary<string, double>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="buy")
                {
                    break;
                }

                string[] splittedInput = input.Split().ToArray();
                string product = splittedInput[0];
                double singlePrice = double.Parse(splittedInput[1]);
                int quantity = int.Parse(splittedInput[2]);

                if (!productsQuantity.ContainsKey(product))
                {
                    productsQuantity[product] = quantity;
                    productsAllPrice[product] = quantity * singlePrice;
                }

                else
                {
                    foreach (var item in productsQuantity)
                    {
                        if (item.Key== product)
                        {
                            productsQuantity[product] = item.Value + quantity;
                            productsAllPrice[product] = (item.Value + quantity)*singlePrice;
                            break;
                        }
                    }
                }

            }

            foreach (var item in productsAllPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
