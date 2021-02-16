using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string input = string.Empty;
            while (true)
            {
               string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                string[] inputARR = input.Split();
                
                switch (inputARR[0])
                {
                    case "Add":
                        int numberAdd = int.Parse(inputARR[1]);
                        numbers.Add(numberAdd);
                        break;

                    case "Remove":
                        int numberRemove = int.Parse(inputARR[1]);

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers.Remove(numberRemove);
                        }

                        break;

                    case "RemoveAt":

                        int numberAt = int.Parse(inputARR[1]);
                        numbers.RemoveAt(numberAt);
                        break;

                    case "Insert":
                        int indexNumber = int.Parse(inputARR[2]);
                        int numberInsert = int.Parse(inputARR[1]);
                        numbers.Insert(indexNumber, numberInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
