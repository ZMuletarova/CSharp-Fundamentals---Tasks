using System;
using System.Linq;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordOne = Console.ReadLine().ToLower();
            var wordTwo = Console.ReadLine().ToLower();

            while (true)
            {
                if (wordTwo.Contains(wordOne))
                {
                    wordTwo = wordTwo.Replace(wordOne, string.Empty);
                }
                else
                {
                    Console.WriteLine(wordTwo);
                    break;
                }
            }
        }
    }
}
