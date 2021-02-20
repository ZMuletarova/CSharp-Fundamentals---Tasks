using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            int powNumber = int.Parse(Console.ReadLine());
            double area = MathPow(firstNumber, powNumber);
            Console.WriteLine(area);
        }

         static double MathPow(double firstNumber, int numberToPow)
        {
            double finalSum = 1;
            for (int i = 0; i < numberToPow; i++)
            {
                finalSum =finalSum*firstNumber;

            }
            return finalSum;
        }
    }
}
