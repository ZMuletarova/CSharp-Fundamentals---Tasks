using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                string[] splittedInput = input.Split(" : ").ToArray();
                string courseName = splittedInput[0];
                string studentName = splittedInput[1];

                if (!info.ContainsKey(courseName))
                {
                    info[courseName] = new List<string>();
                    info[courseName].Add(studentName);
                }
                else
                {
                    info[courseName].Add(studentName);
                }
            }

            var newDic = info.OrderByDescending(x => x.Value.Count).ToList();

            foreach (var item in newDic)
            {
                Console.Write($"{item.Key}: ");
                Console.WriteLine(item.Value.Count);
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value.OrderBy(x=>x))}");
            }
        }
    }
}
