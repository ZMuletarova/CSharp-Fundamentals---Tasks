using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _3._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                string[] splittedCommand = command.Split("->").ToArray();

                if (command== "Statistics")
                {
                    break;
                }
                else if (splittedCommand[0]=="Add")
                {
                    string userName = splittedCommand[1];

                    if (!dic.ContainsKey(splittedCommand[1]))
                    {
                        dic[userName] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                }
                else if (splittedCommand[0] == "Send")
                {
                    string sentEmail = splittedCommand[2];

                    foreach (var item in dic)
                    {
                        if (item.Key==splittedCommand[1])
                        {
                            dic[item.Key].Add(splittedCommand[2]);
                        }
                    }
                }
                else if (splittedCommand[0] == "Delete")
                {
                    string userName = splittedCommand[1];

                    if (dic.ContainsKey(userName))
                    {
                        dic.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }
            }

            var finalDic = dic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToArray();
            Console.WriteLine($"Users count: {dic.Values.Count}");

            foreach (var item in finalDic)
            {
                Console.WriteLine(item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"- {item.Value[i]}");
                }
            }
        }
    }
}
