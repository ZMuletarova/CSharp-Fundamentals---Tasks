using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSynonims = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List <string>>();

            for (int i = 0; i < numberOfSynonims; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                words[word].Add(synonim);
            }

            foreach (var item in words)
            {
                //string word = item.Key;
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
