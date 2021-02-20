using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSumOfEvenDigits();
        }

        static void GetSumOfEvenDigits()
        {
            int number = int.Parse(Console.ReadLine());
            
            int oneNumber = 0;
            int sumEven = 0;
            int sumOdd = 0;
            
            while (number!=0)
            {
                oneNumber = number % 10;
                number = number / 10;

                if (oneNumber %2 == 0)
                {
                    sumEven += oneNumber;
                }

                else
                {
                    sumOdd += oneNumber;
                }
            }

            int all = sumOdd * sumEven;
            Console.WriteLine(all);
        }
    }
}
