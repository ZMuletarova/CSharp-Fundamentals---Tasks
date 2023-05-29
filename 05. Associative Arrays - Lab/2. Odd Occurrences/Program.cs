using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Odd_Occurrences_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            var splittedInput = input.Split();

            var dic = new Dictionary<string, int>();

            for (int i = 0; i < splittedInput.Length; i++)
            {
                if (!dic.ContainsKey(splittedInput[i]))
                {
                    dic[splittedInput[i]] = 1;
                }
                selse
                {
                    dic[splittedInput[i]] += 1;
                }
            }

            foreach (var item in dic)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
