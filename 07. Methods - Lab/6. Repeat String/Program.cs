using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat();
        }
        static void Repeat()
        {
            string text = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Console.Write(text);
            }
        }
    }
}
