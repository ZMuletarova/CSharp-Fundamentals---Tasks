using System;
using System.Linq;

namespace _2.__Character_Multiplier_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string inputOne = input[0];
            string inputTwo = input[1];
            double totalSum = 0;
            double multiply = 0;

            if (inputOne.Length == inputTwo.Length)
            {
                for (int j = 0; j < inputOne.Length; j++)
                {
                    multiply = inputOne[j] * inputTwo[j];
                    totalSum += multiply;
                }

                Console.WriteLine(totalSum);
            }

            else
            {
                if (inputOne.Length > inputTwo.Length)
                {
                    for (int j = 0; j < inputOne.Length; j++)
                    {
                        if (j >= inputTwo.Length)
                        {
                            multiply = inputOne[j] * 1;
                            totalSum += multiply;
                        }
                        else
                        {
                            multiply = inputOne[j] * inputTwo[j];
                            totalSum += multiply;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < inputTwo.Length; j++)
                    {
                        if (j >= inputOne.Length)
                        {
                            multiply = inputTwo[j] * 1;
                            totalSum += multiply;
                        }
                        else
                        {
                            multiply = inputOne[j] * inputTwo[j];
                            totalSum += multiply;
                        }
                    }
                }
                Console.WriteLine(totalSum);
            }
        }
    }
}
