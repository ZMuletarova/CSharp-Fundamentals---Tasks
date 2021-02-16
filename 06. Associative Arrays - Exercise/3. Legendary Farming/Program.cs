using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            string input = Console.ReadLine().ToLower();
            string[] splittedInput = input.Split().ToArray();

            for (int i = 1; i < splittedInput.Length; i++)
            {
                if (i % 2 != 0 && i > 0)
                {
                    if (!dic.ContainsKey(splittedInput[i]))
                    {
                        dic[splittedInput[i]] = int.Parse(splittedInput[i - 1]);

                        if (dic[splittedInput[i]] >= 250)
                        {
                            if (splittedInput[i] == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                dic[splittedInput[i]] -= 250;
                                break;
                            }

                            else if (splittedInput[i] == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                dic[splittedInput[i]] -= 250;
                                break;
                            }

                            else if (splittedInput[i] == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                dic[splittedInput[i]] -= 250;
                                break;
                            }
                        }
                    }

                    else

                    {
                        dic[splittedInput[i]] += int.Parse(splittedInput[i - 1]);

                        if (dic[splittedInput[i]] >= 250)
                        {
                            if (splittedInput[i] == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                dic[splittedInput[i]] -= 250;
                                break;
                            }

                            else if (splittedInput[i] == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                dic[splittedInput[i]] -= 250;
                                break;
                            }

                            else if (splittedInput[i] == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                dic[splittedInput[i]] -= 250;
                                break;
                            }
                        }
                    }
                }
            }

            var final = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();

            foreach (var pr in dic)
            {
                if (pr.Key == "shards")
                {
                    final[pr.Key] = pr.Value;
                }

                else if (pr.Key == "fragments")
                {
                    final[pr.Key] = pr.Value;
                }

                else if (pr.Key == "motes")
                {
                    final[pr.Key] = pr.Value;
                }

                else
                {
                    junk[pr.Key] = pr.Value;
                }
                
            }
            if (!final.ContainsKey("shards"))
            {
                final["shards"] = 0;
            }

            else if (!final.ContainsKey("fragments"))
            {
                final["fragments"] = 0;
            }

            else if (!final.ContainsKey("motes"))
            {
                final["motes"] = 0;
            }

            var finalOne = final.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

            foreach (var finalKey in finalOne)
            {
                Console.WriteLine($"{finalKey.Key}: {finalKey.Value}");
            }

            var finalJunk = junk.OrderBy(x => x.Key).ToArray();

            foreach (var junks in finalJunk)
            {
                Console.WriteLine($"{junks.Key}: {junks.Value}");
            }
        }
    }
 }
