using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cardsOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> cardsTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int allSumCards = 0;

            for (int i = 0; i < cardsOne.Count; i++)
            {
                if (cardsOne.Count <= 0 || cardsTwo.Count <= 0)
                {
                    break;
                }

                if (cardsOne[i] == cardsTwo[i])
                {
                    cardsOne.RemoveAt(i);
                    cardsTwo.RemoveAt(i);
                }

                else
                {
                    if (cardsOne[i] > cardsTwo[i])
                    {
                        cardsOne.Insert(cardsOne.Count, cardsOne[0]);
                        cardsOne.Insert(cardsOne.Count, cardsTwo[0]);
                        cardsOne.RemoveAt(0);
                        cardsTwo.RemoveAt(0);
                    }

                    else if (cardsOne[i] < cardsTwo[i])
                    {
                        cardsTwo.Insert(cardsTwo.Count, cardsTwo[0]);
                        cardsTwo.Insert(cardsTwo.Count, cardsOne[0]);
                        cardsTwo.RemoveAt(0);
                        cardsOne.RemoveAt(0);
                    }
                }

                i = -1;
            }

            if (cardsOne.Count > cardsTwo.Count)
            {
                for (int i = 0; i < cardsOne.Count; i++)
                {
                    allSumCards += cardsOne[i];
                }
                Console.WriteLine($"First player wins! Sum: {allSumCards}");
            }

            else
            {
                for (int i = 0; i < cardsTwo.Count; i++)
                {
                    allSumCards += cardsTwo[i];
                }
                Console.WriteLine($"Second player wins! Sum: {allSumCards}");
            }
        }
    }
}
