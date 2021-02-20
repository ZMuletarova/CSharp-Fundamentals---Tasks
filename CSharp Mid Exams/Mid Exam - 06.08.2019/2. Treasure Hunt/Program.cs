using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            while (true)
            {
                string commands = Console.ReadLine();
              
                if (commands== "Yohoho!")
                {
                    break;
                }

                string[] commandsARR = commands.Split(" ");

                if (commandsARR[0]=="Loot")
                {
                    for (int i = 1; i <commandsARR.Length; i++)
                    {
                        if (!input.Contains(commandsARR[i]))
                        {
                            input.Insert(0, commandsARR[i]);
                        }
                    }
                }

                else if (commandsARR[0] == "Drop")
                {
                    int indexNumber = int.Parse(commandsARR[1]);

                    if (indexNumber>=0 && indexNumber<input.Count)
                    {
                        input.Insert(input.Count, input[indexNumber]);
                        input.RemoveAt(indexNumber);
                    }
                }

                else if (commandsARR[0] == "Steal")
                {
                    int indexNumber = int.Parse(commandsARR[1]);

                    if (indexNumber>=input.Count)
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (i == input.Count - 1)
                            {
                                Console.Write(input[i]);
                                break;
                            }
                            Console.Write(input[i] + ", ");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < input.Count; i++)
                        {
                            input.Remove(input[i]);
                            i--;
                        }
                    }

                    else
                    {
                        int nomers = input.Count - indexNumber;
                        for (int i = nomers; i < input.Count; i++)
                        {
                            if (i==input.Count-1)
                            {
                                Console.Write(input[i]);
                                break;
                            }
                            Console.Write(input[i] + ", ");
                        }
                        Console.WriteLine();
                        for (int i = nomers; i < input.Count; i++)
                        {
                            input.Remove(input[i]);
                            i--;
                        }
                    }
                }
            }


            if (input.Count>0)
            {
                double sum = 0;

                for (int i = 0; i < input.Count; i++)
                {
                    Char[] newWord = input[i].ToCharArray();
                    for (int j = 0; j < newWord.Length; j++)
                    {
                        sum++;
                    }
                }

                double result = sum / input.Count;
                Console.WriteLine($"Average treasure gain: {result:f2} pirate credits.");
            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
