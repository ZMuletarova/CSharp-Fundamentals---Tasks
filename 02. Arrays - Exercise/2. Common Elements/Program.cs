using System;
using System.Linq;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            var firstSplittedArray = firstLine.Split();
            var secondSplittedArray = secondLine.Split();

            for (int i = 0; i < firstSplittedArray.Length; i++)
            {
                for (int j = 0; j < secondSplittedArray.Length; j++)
                {
                    if (firstSplittedArray[i] == secondSplittedArray[j])

                    {
                        Console.Write(firstSplittedArray[i] + " ");
                    }
                }
            } 
        }
    }
}
