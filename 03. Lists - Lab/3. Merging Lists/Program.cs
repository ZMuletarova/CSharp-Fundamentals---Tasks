using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int countLenght = numbersOne.Count + numbersTwo.Count;
            List<int> allNumbers = new List<int>();

            for (int i = 0; i < countLenght; i++)
            {
                if(numbersOne.Count-1>=i)
                {
                    allNumbers.Add(numbersOne[i]);
                }

                if (numbersTwo.Count-1>=i)
                {
                    allNumbers.Add(numbersTwo[i]);
                }
            }

            for (int i = 0; i < allNumbers.Count; i++)
            {
                Console.Write(allNumbers[i] + " ");
            }
        }
    }
}
