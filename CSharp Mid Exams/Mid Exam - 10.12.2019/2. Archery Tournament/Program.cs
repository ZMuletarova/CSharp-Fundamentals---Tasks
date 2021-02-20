using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            int power = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="Game over")
                {
                    break;
                }
                string[] splittedInput = command.Split(" ");
              

                if (splittedInput[0]=="Shoot")
                {
                    string[] secondSplit = splittedInput[1].Split('@');

                    if (secondSplit[0]=="Left")
                    {
                        int lenght = int.Parse(secondSplit[2]);
                        int startIndex = int.Parse(secondSplit[1]);

                        if (startIndex<0 || startIndex>=numbers.Count)
                        {
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < lenght; i++)
                            {
                                if (startIndex == 0)
                                {
                                    startIndex = numbers.Count - 1;
                                }
                                else
                                {
                                    startIndex--;
                                }
                            }

                            if (numbers[startIndex] <= 5)
                            {
                                power += numbers[startIndex];
                                numbers[startIndex] = 0;
                            }

                            else
                            {
                                numbers[startIndex] -= 5;
                                power += 5;
                            }
                        }
                    }

                    else if (secondSplit[0] == "Right")
                    {
                        int lenght = int.Parse(secondSplit[2]);
                        int startIndex = int.Parse(secondSplit[1]);

                        if (startIndex < 0 || startIndex >= numbers.Count)
                        {
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < lenght; i++)
                            {
                                if (startIndex == numbers.Count-1)
                                {
                                    startIndex = 0;
                                }
                                else
                                {
                                    startIndex++;
                                }
                            }

                            if (numbers[startIndex] <= 5)
                            {
                                power += numbers[startIndex];
                                numbers[startIndex] = 0;
                            }

                            else
                            {
                                numbers[startIndex] -= 5;
                                power += 5;
                            }
                        }
                    }
                }

                if (command == "Reverse")
                {
                    numbers.Reverse();
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i==numbers.Count-1)
                {
                    Console.Write(numbers[i]);
                    break;
                }
                Console.Write(numbers[i] + " - ");
            }
            Console.WriteLine();
            Console.WriteLine($"Iskren finished the archery tournament with {power} points!");
        }
    }
}
