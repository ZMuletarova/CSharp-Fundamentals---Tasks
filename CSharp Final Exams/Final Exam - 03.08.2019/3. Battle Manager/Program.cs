using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
          var dic = new Dictionary<string, int[]>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command== "Results")
                {
                    break;
                }

                string[] splittedCommand = command.Split(":").ToArray();

                if (splittedCommand[0]=="Add")
                {
                    string personName = splittedCommand[1];
                    int health = int.Parse(splittedCommand[2]);
                    int energy = int.Parse(splittedCommand[3]);

                    if (!dic.ContainsKey(personName))
                    {
                        dic[personName] = new int[] { health, energy };
                    }

                    else
                    {
                        dic[personName][0] += health;
                    }
                }

                else if (splittedCommand[0]== "Attack")
                {
                    string attackerName = splittedCommand[1];
                    string defenderName = splittedCommand[2];
                    int damage = int.Parse(splittedCommand[3]);

                    if (dic.ContainsKey(attackerName) && dic.ContainsKey(defenderName))
                    {
                        dic[defenderName][0] -= damage;

                        if (dic[defenderName][0]<=0)
                        {
                            dic.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }

                        dic[attackerName][1] -= 1;

                        if (dic[attackerName][1] <= 0)
                        {
                            dic.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                }

                else if (splittedCommand[0]=="Delete")
                {
                    string userName = splittedCommand[1];

                    if (dic.ContainsKey(userName))
                    {
                        dic.Remove(userName);
                    }

                    if (userName=="All")
                    {
                        dic = new Dictionary<string, int[]>();
                    }
                }
            }

            Console.WriteLine($"People count: {dic.Count}");

            var finalDic = dic.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToArray();
            //var final = dic.OrderByDescending(x => x.Value[0] + x.Value[1]).ThenBy(x => x.Key).ToArray();

            foreach (var item in finalDic)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
