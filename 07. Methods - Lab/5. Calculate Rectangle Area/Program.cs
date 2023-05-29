using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widch = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());
            double area = Rectangle(widch, heigh);

            Console.WriteLine(area);
        }

        static double Rectangle(double widch, double heigh)
        {
            return widch * heigh;
        }
    }
}
