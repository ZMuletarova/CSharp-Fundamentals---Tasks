using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numbersTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = numbersTwo[0];
            int powerBombNumber = numbersTwo[1];
            int indexNumberBomb = 0;
            int allSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    indexNumberBomb = i;

                    for (int j = 0; j < powerBombNumber; j++)
                    {
                        if (indexNumberBomb <= 0)
                        {
                            numbers.RemoveAt(1);
                        }
                        else if (indexNumberBomb >= numbers.Count - 1)
                        {
                            numbers.RemoveAt(indexNumberBomb--);
                        }
                        else
                        {
                            numbers.RemoveAt(indexNumberBomb - 1);
                            indexNumberBomb = indexNumberBomb - 1;
                            numbers.RemoveAt(indexNumberBomb + 1);
                        }
                    }
                    numbers.Remove(bombNumber);
                    i = -1;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                allSum += numbers[i];
            }
            Console.WriteLine(allSum);
        }
    }
}
