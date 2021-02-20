using System;
using System.Linq;
using System.Collections.Generic;
 

namespace _3._Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesFrogs = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] splittedCommand = command.Split(" ");
                
                if (splittedCommand[0]=="Join")
                {
                    namesFrogs.Add(splittedCommand[1]);
                }

                else if (splittedCommand[0] == "Jump")
                {
                    int numberIndex = int.Parse(splittedCommand[2]);
                    if (numberIndex>=0 && numberIndex<namesFrogs.Count)
                    {
                        namesFrogs.Insert(numberIndex, splittedCommand[1]);
                    }
                }

                else if (splittedCommand[0] == "Dive")
                {
                    int numberIndex = int.Parse(splittedCommand[1]);
                    if (numberIndex >= 0 && numberIndex < namesFrogs.Count)
                    {
                        namesFrogs.RemoveAt(numberIndex);
                    }
                }

                else if (splittedCommand[0] == "First")
                {
                    int numberIndex = int.Parse(splittedCommand[1]);
                    
                    if (numberIndex > 0)
                    {
                        for (int i = 0; i < namesFrogs.Count; i++)
                        {
                            if (i==numberIndex)
                            {
                                break;
                            }
                            Console.Write(namesFrogs[i]+ " ");
                           
                        }
                    }
                    Console.WriteLine();
                }

                else if (splittedCommand[0] == "Last")
                {
                    int numberIndex = int.Parse(splittedCommand[1]);
                    int numbersToPrint = namesFrogs.Count - numberIndex;

                    for (int i = numbersToPrint; i < namesFrogs.Count; i++)
                    {
                        Console.Write(namesFrogs[i] + " ");
                    }

                    Console.WriteLine();
                }

                else if (splittedCommand[0] == "Print")
                {
                    if (splittedCommand[1]=="Normal")
                    {
                        //countNomral++;
                        Console.Write("Frogs: ");
                        for (int i = 0; i < namesFrogs.Count; i++)
                        {
                            Console.Write(namesFrogs[i] + " ");
                        }
                        break;
                    }
                    
                    else if (splittedCommand[1] == "Reversed")
                    {
                        //countReversed++;
                        Console.Write("Frogs: ");
                        for (int i = namesFrogs.Count - 1; i >= 0; i--)
                        {
                            Console.Write(namesFrogs[i] + " ");
                        }
                        break;
                    }
                }
            }
        }
    }
}
