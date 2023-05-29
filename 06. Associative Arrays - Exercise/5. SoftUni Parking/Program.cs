using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var info = Console.ReadLine().Split().ToArray();
                string action = info[0];
                string userName = info[1];

                if (action == "register")
                {
                    string licensePlateNumber = info[2];
                    if (!dic.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                        dic.Add(userName, licensePlateNumber);
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }

                else if (action == "unregister")
                {
                    if (!dic.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");

                        foreach (var item in dic)
                        {
                            if (userName == item.Key)
                            {
                                dic.Remove(item.Key);
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
