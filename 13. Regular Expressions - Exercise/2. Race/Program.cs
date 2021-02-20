using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            var dic = new Dictionary<string, int>();
            string name = string.Empty;
            int finalKm = 0;

            while (true)
            {
                string newInput = Console.ReadLine();
                name = string.Empty;
                finalKm = 0;

                if (newInput== "end of race")
                {
                    break;
                }

                for (int i = 0; i < newInput.Length; i++)
                {
                    if (newInput[i]>=65 && newInput[i]<=90 || newInput[i] >= 97 && newInput[i] <= 122)
                    {
                        name += newInput[i];
                    }

                    else if (newInput[i] >= 48 && newInput[i] <= 57)
                    {
                        string km = newInput[i].ToString();
                        finalKm += (int.Parse)(km);
                    }
                }

                if (input.Contains(name))
                {
                    if (!dic.ContainsKey(name))
                    {
                        dic[name] = finalKm;
                    }

                    else
                    {
                        dic[name] +=finalKm;
                    }
                }

                else
                {
                    continue;
                }
            }

            var finalDictionary = dic.OrderByDescending(x => x.Value).Take(3).ToArray();
            int count = 1;

            foreach (var item in finalDictionary)
            {
                if (count==1)
                {
                    Console.WriteLine($"{count}st place: {item.Key}");
                }
                

                if (count==2)
                {
                    Console.WriteLine($"{count}nd place: {item.Key}");
                }

                else if (count == 3)
                {
                    Console.WriteLine($"{count}rd place: {item.Key}");
                }

                count++;
            }
        }
    }
}
