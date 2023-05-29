using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Jerry_is_going_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string messCommand = Console.ReadLine();
                if (messCommand=="End")
                {
                    break;
                }

                var splittedCommand = messCommand.Split(" ");
                string command = splittedCommand[0];

                switch (messCommand)
                {
                    case "Add":
                        int numberAdd = int.Parse(splittedCommand[1]);
                        inputNumbers.Add(numberAdd);
                        break;

                    case "Insert":
                        numberAdd = int.Parse(splittedCommand[1]);
                        int indexNumber = int.Parse(splittedCommand[2]);
                        if (indexNumber<inputNumbers.Count && indexNumber>=0)
                        {
                            inputNumbers.Insert(indexNumber, numberAdd);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        indexNumber = int.Parse(splittedCommand[1]);
                        if (indexNumber<inputNumbers.Count && indexNumber>=0)
                        {
                            inputNumbers.RemoveAt(indexNumber);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":

                        string direction = splittedCommand[1];
                        int countNumber = int.Parse(splittedCommand[2]);

                        if (direction=="left")
                        {
                            for (int i = 0; i < countNumber; i++)
                            {
                                inputNumbers.Add(inputNumbers[0]);
                                inputNumbers.RemoveAt(0);
                            }
                        }

                        else if(direction=="right")
                        {
                            for (int i = 0; i < countNumber; i++)
                            {
                                inputNumbers.Insert(0,inputNumbers[inputNumbers.Count-1]);
                                inputNumbers.RemoveAt(inputNumbers.Count - 1) ;
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
