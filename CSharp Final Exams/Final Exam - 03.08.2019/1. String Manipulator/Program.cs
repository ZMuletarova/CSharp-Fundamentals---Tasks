using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Final_Exam_03._08._2019_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Done")
                {
                    break;
                }

                string[] splittedCommand = command.Split().ToArray();

                if (splittedCommand[0]== "Change")
                {
                    input = input.Replace(splittedCommand[1], splittedCommand[2]);
                    Console.WriteLine(input);
                }
                else if (splittedCommand[0]== "Includes")
                {
                    if (input.Contains(splittedCommand[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (splittedCommand[0]== "End")
                {
                    string[] check = input.Split(" ");
                    if (check[check.Length-1]==splittedCommand[1])
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (splittedCommand[0]== "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (splittedCommand[0]== "FindIndex")
                {
                    int index = input.IndexOf(splittedCommand[1]);
                    Console.WriteLine(index);
                }
                else if (splittedCommand[0]== "Cut")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int lenght = int.Parse(splittedCommand[2]);

                    string subWord = input.Substring(startIndex, lenght);
                    Console.WriteLine(subWord);
                }
            }
        }
    }
}
