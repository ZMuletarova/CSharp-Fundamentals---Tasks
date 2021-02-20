using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _3._Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int[]>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Log out")
                {
                    break;
                }

                string[] splittedCommand = command.Split(": ").ToArray();

                if (splittedCommand[0] == "New follower")
                {
                    if (!dic.ContainsKey(splittedCommand[1]))
                    {
                        dic[splittedCommand[1]] = new int[] { 0, 0 };
                    }
                }

                else if (splittedCommand[0] == "Like")
                {
                    string userName = splittedCommand[1];
                    int count = int.Parse(splittedCommand[2]);

                    if (!dic.ContainsKey(userName))
                    {
                        dic[userName] = new int[] { count, 0 };
                    }

                    else
                    {
                        dic[userName][0] += count;
                    }
                }

                else if (splittedCommand[0] == "Comment")
                {
                    if (!dic.ContainsKey(splittedCommand[1]))
                    {
                        dic[splittedCommand[1]] = new int[] { 0, 1 };
                    }

                    else
                    {
                        dic[splittedCommand[1]][1] += 1;
                    }
                }

                else if (splittedCommand[0] == "Blocked")
                {
                    if (dic.ContainsKey(splittedCommand[1]))
                    {
                        dic.Remove(splittedCommand[1]);
                    }

                    else
                    {
                        Console.WriteLine($"{splittedCommand[1]} doesn't exist.");
                    }
                }
            }

            Console.WriteLine($"{dic.Count} followers");

            var final = dic.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToArray();

            foreach (var item in final)
            {
                Console.WriteLine($"{item.Key}: {item.Value[0] + item.Value[1]}");
            }
        }
    }
}
