using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0)
                {
                    int n = numbers[i];
                    numbers.Remove(n);
                    i -= 1; 
                }
            }

            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
            }

            else
            {
                numbers.Reverse();

                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]+ " ");
                }
            }
        }
    }
}
