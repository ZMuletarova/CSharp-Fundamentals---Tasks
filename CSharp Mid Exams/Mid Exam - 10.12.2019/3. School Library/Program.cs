using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                string[] splittedInput = command.Split(" | ");

                if (splittedInput[0] == "Add Book")
                {
                    if (books.Contains(splittedInput[1]))
                    {
                        continue;
                    }

                    else
                    {
                        books.Insert(0, splittedInput[1]);
                    }
                }

                else if (splittedInput[0] == "Take Book")
                {
                    int index = 0;

                    if (books.Contains(splittedInput[1]))
                    {
                        books.Remove(splittedInput[1]);
                    }

                    else
                    {
                        continue;
                    }
                }
                else if (splittedInput[0] == "Insert Book")
                {
                    books.Add(splittedInput[1]);
                }

                else if (splittedInput[0] == "Swap Books")
                {
                    int indexFirst = 0;
                    int indexSecond = 0;

                    if (books.Contains(splittedInput[1]) && books.Contains(splittedInput[2]))
                        {
                        for (int i = 0; i < books.Count; i++)
                        {

                            if (splittedInput[1] == books[i])
                            {
                                indexFirst = i;
                            }

                            else if (splittedInput[2] == books[i])
                            {
                                indexSecond = i;
                            }
                        }

                        books.Insert(indexFirst, books[indexSecond]);
                        books.Insert(indexSecond + 1, books[indexFirst + 1]);
                        books.RemoveAt(indexFirst + 1);
                        books.RemoveAt(indexSecond + 1);
                    }

                    else
                    {
                        continue;
                    }
                }

                else if (splittedInput[0] == "Check Book")
                {
                    int index = int.Parse(splittedInput[1]);
                    if (index >= 0 && index < books.Count)
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            if (index == i)
                            {
                                Console.Write(books[i]);
                                Console.WriteLine();
                                break;
                            }
                        }
                    }

                    else
                    {
                        continue;
                    }
                }
            }

            for (int i = 0; i < books.Count; i++)
            {
                if (i== books.Count-1)
                {
                    Console.Write(books[i]);
                    break;
                }
                Console.Write(books[i] + ", ");
            }
        }
    }
}
