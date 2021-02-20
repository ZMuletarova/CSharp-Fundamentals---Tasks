using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            if (product=="coffee")
            {
                Coffee();
            }

            else if (product=="coke")
            {
                Coke();
            }

            else if (product=="water")
            {
                Water();
            }

            else if (product == "snacks")
            {
                Snacks();
            }
        }

       static void Coffee()
        {
            double singlePrice = 1.50;
            double quantities =int.Parse(Console.ReadLine());
            double sum = singlePrice * quantities;

            Console.WriteLine($"{sum:f2}");
        }


        static void Coke()
        {
            double singlePrice = 1.40;
            double quantities = int.Parse(Console.ReadLine());
            double sum = singlePrice * quantities;

            Console.WriteLine($"{sum:f2}");
        }

        static void Water()
        {
            double singlePrice = 1.00;
            double quantities = int.Parse(Console.ReadLine());
            double sum = singlePrice * quantities;

            Console.WriteLine($"{sum:f2}");
        }

        static void Snacks()
        {
            double singlePrice = 2.00;
            double quantities = int.Parse(Console.ReadLine());
            double sum = singlePrice * quantities;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
