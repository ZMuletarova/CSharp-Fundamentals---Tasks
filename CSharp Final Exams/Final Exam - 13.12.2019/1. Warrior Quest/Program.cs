using System;
using System.Linq;
using System.Collections.Generic;

namespace Final_Exam_13._12._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "For Azeroth")
                {
                    break;
                }

                string[] splittedCommand = command.Split().ToArray();

                if (command == "GladiatorStance")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }

                else if (command == "DefensiveStance")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }

                else if (splittedCommand[0] == "Dispel")
                {
                    int index = int.Parse(splittedCommand[1]);

                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, splittedCommand[2]);
                        input = input.Remove(index + 1, 1);
                        Console.WriteLine("Success!");
                    }

                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }

                else if (splittedCommand[0] == "Target")
                {
                    if (splittedCommand[1] == "Change")
                    {
                        if (input.Contains(splittedCommand[2]))
                        {
                            input = input.Replace(splittedCommand[2], splittedCommand[3]);
                            Console.WriteLine(input);
                        }
                    }

                    else if (splittedCommand[1] == "Remove")
                    {
                        if (input.Contains(splittedCommand[2]))
                        {
                            input = input.Replace(splittedCommand[2], "");
                            Console.WriteLine(input);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }

                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
