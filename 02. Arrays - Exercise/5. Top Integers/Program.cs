using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
          
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int currentNumber = numbers[i];
                bool isTop = true;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    int otherNumber = numbers[j];

                    if (currentNumber<=otherNumber)
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write(currentNumber + " ");
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
