using System;
using System.Linq;


namespace Final_Exam_09._08._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Sign up")
                {
                    break;
                }

                string[] splittedCommand = command.Split(" ").ToArray();

                if (splittedCommand[0] == "Case")
                {
                    if (splittedCommand[1] == "lower")
                    {
                        userName = userName.ToLower();
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        userName = userName.ToUpper();
                        Console.WriteLine(userName);
                    }
                }
                else if (splittedCommand[0] == "Reverse")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);
                    int lenght = (endIndex - startIndex) + 1;

                    if (startIndex >= 0 && endIndex > startIndex && endIndex < userName.Length)
                    {
                        string subWord = userName.Substring(startIndex, lenght);
                        string newWord = string.Empty;
                        for (int i = subWord.Length - 1; i >= 0; i--)
                        {
                            newWord += subWord[i];
                        }
                        Console.WriteLine(newWord);
                    }
                }
                else if (splittedCommand[0] == "Cut")
                {
                    if (userName.Contains(splittedCommand[1]))
                    {
                        string cut = userName.Replace(splittedCommand[1], "");
                        Console.WriteLine(cut);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {splittedCommand[1]}.");
                    }
                }
                else if (splittedCommand[0] == "Replace")
                {
                    userName = userName.Replace(splittedCommand[1], "*");
                    Console.WriteLine(userName);
                }
                else if (splittedCommand[0] == "Check")
                {
                    if (userName.Contains(splittedCommand[1]))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {splittedCommand[1]}.");
                    }
                }
            }
        }
    }
}
