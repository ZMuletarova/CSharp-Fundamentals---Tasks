using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            int count = 0;
            List<string> finalList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string message = Console.ReadLine();
                string[] splittedMessage = message.Split();

                if (splittedMessage[1]=="is" && splittedMessage[2]=="going!")
                {
                    if (!finalList.Contains(splittedMessage[0]))
                    {
                        finalList.Add(splittedMessage[0]);
                    }

                    else
                    {
                        Console.WriteLine($"{splittedMessage[0]} is already in the list!");
                    }
                }

                if (splittedMessage[2]=="not")
                {
                    if (!finalList.Contains(splittedMessage[0]))
                    {
                        Console.WriteLine($"{splittedMessage[0]} is not in the list!");
                    }

                    else
                    {
                        finalList.Remove(splittedMessage[0]);
                    }
                }
            }

            for (int i = 0; i < finalList.Count; i++)
            {
                Console.WriteLine(finalList[i]);
            }
        }
    }
}
