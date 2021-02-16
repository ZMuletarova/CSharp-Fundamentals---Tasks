using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] n = input.Split();

            for (int i = n.Length-1; i >=0; i--)
            {
                Console.Write(n[i] + " ");
            }
        }
    }
}
