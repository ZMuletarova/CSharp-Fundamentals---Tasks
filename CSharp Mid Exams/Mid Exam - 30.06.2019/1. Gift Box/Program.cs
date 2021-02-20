using System;

namespace Mid_Exam_30._06._2019_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sizeOfSide = decimal.Parse(Console.ReadLine());
            int numberOfSheets = int.Parse(Console.ReadLine());
            decimal covers = decimal.Parse(Console.ReadLine());

            decimal area = sizeOfSide * sizeOfSide * 6M;
            int sizeOf20 = numberOfSheets / 3;

            decimal cover100Procent = (numberOfSheets - sizeOf20) * covers;
            decimal cover75Procent = sizeOf20 * 0.25M * covers;
            decimal totalSum = cover100Procent + cover75Procent;
            decimal result = (totalSum / area) * 100;
            Console.WriteLine($"You can cover {result:f2}% of the box.");
        }
    }
}
