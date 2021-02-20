using System;
using System.Linq;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (text.Contains(input[i]))
                {
                    text = text.Replace(input[i], new string('*', input[i].Length));
                }
            }
            Console.Write(text);
        }
    }
}
