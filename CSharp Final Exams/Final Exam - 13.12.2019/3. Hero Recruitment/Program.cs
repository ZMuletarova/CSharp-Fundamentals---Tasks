using System;
using System.Linq;
using System.Collections.Generic;


namespace _3._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {

            var dic = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] splittedCommand = command.Split(" ").ToArray();

                if (splittedCommand[0] == "Enroll")
                {
                    if (!dic.ContainsKey(splittedCommand[1]))
                    {
                        dic[splittedCommand[1]] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{splittedCommand[1]} is already enrolled.");
                    }
                }
                else if (splittedCommand[0] == "Learn")
                {
                    if (!dic.ContainsKey(splittedCommand[1]))
                    {
                        Console.WriteLine($"{splittedCommand[1]} doesn't exist.");
                    }
                    else
                    {

                        foreach (var item in dic)
                        {
                            if (item.Key == splittedCommand[1])
                            {
                                if (dic[item.Key].Contains(splittedCommand[2]))
                                {
                                    Console.WriteLine($"{splittedCommand[1]} has already learnt {splittedCommand[2]}.");
                                }
                                else
                                {
                                    dic[item.Key].Add(splittedCommand[2]);
                                }
                            }
                        }
                    }
                }

                else if (splittedCommand[0] == "Unlearn")
                {
                    if (!dic.ContainsKey(splittedCommand[1]))
                    {
                        Console.WriteLine($"{splittedCommand[1]} doesn't exist.");
                    }
                    else
                    {
                        foreach (var item in dic)
                        {
                            if (item.Key == splittedCommand[1])
                            {
                                if (dic[item.Key].Contains(splittedCommand[2]))
                                {
                                    dic[item.Key].Remove(splittedCommand[2]);
                                }
                                else
                                {
                                    Console.WriteLine($"{splittedCommand[1]} doesn't know {splittedCommand[2]}.");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Heroes:");
            var final = dic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToArray();

            foreach (var item in final)
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");

            }
        }
    }
}
