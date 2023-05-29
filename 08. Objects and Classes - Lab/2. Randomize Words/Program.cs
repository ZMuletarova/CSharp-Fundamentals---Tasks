using System;

namespace _2._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(" ");
            Random random = new Random();

            for (int i = 0; i < splittedInput.Length; i++)
            {
                int index = random.Next(0, splittedInput.Length);
                string temp = splittedInput[index];
                splittedInput[index] = splittedInput[i];
                splittedInput[i] = temp;
            }
            Console.WriteLine(string.Join("\n", splittedInput));
        }
    }
}
