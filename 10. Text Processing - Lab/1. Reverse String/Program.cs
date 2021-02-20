using System;
using System.Linq;

namespace Strings_and_Text_Processing_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                char[] newWord = input.ToCharArray();
                char[] newOne = new char[0];

                for (int i = 0; i < input.Length; i++)
                {
                    newOne = newWord.Reverse().ToArray();
                }

                Console.Write($"{input} = ");

                for (int i = 0; i < newOne.Length; i++)
                {
                    Console.Write(newOne[i]);

                }
                Console.WriteLine();
            }
        }
    }
}
