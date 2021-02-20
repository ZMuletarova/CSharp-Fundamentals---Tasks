using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }

                string[] splittedCommand = command.Split(" ");
                
                if (splittedCommand[0]== "Complete")

                {
                    int number = int.Parse(splittedCommand[1]);
                    
                    if (number>=0 && number<numbers.Count)
                    {
                        numbers.Insert(number, 0);
                        numbers.RemoveAt(number + 1);
                    }
                }

                else if (splittedCommand[0] == "Change")
                {
                    int index = int.Parse(splittedCommand[1]);
                    int insertNumber = int.Parse(splittedCommand[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, insertNumber);
                        numbers.RemoveAt(index + 1);
                    }
                }

                else if (splittedCommand[0] == "Drop")
                {
                    int index = int.Parse(splittedCommand[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, -1);
                        numbers.RemoveAt(index + 1);
                    }
                }

                else if (splittedCommand[0] == "Count")
                {
                    if (splittedCommand[1] == "Completed")
                    {
                        int completed = 0;
                        
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]==0)
                            {
                                completed++;
                            } 
                        }
                        Console.WriteLine(completed);
                    }

                    else if (splittedCommand[1] == "Dropped")
                    {
                        int droppedNumber = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                          
                            if (numbers[i]<0)
                            {
                                droppedNumber++;
                            }
                        }
                        Console.WriteLine(droppedNumber);
                    }

                    else if (splittedCommand[1] == "Incompleted")
                    {
                        int incompletedNumbers = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > 0 && numbers[i] <= 5)
                            {
                                incompletedNumbers++;
                            }
                        }

                        Console.WriteLine(incompletedNumbers);
                    }
                }

            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0 && numbers[i] <= 5)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
