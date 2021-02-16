using System;
using System.Linq;
using System.Collections.Generic;


namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] splittedCommand = command.Split();

                if (splittedCommand[0] == "end")
                {
                    break;
                }

                else
                {
                    if (splittedCommand[0] == "Delete")
                    {
                        int numberToRemove = int.Parse(splittedCommand[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers.Remove(numberToRemove);
                        }
                    }

                    else if (splittedCommand[0] == "Insert")

                    {
                        int numberToInsert = int.Parse(splittedCommand[1]);
                        int indexNumber = int.Parse(splittedCommand[2]);
                        numbers.Insert(indexNumber, numberToInsert);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
