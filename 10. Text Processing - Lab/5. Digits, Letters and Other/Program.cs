using System;
using System.Linq;
using System.Text;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            char[] splittedInput = input.ToCharArray();
            string text = string.Empty;
            string numbers = string.Empty;
            string symbol = string.Empty;

            for (int i = 0; i < splittedInput.Length; i++)
            {
                if (char.IsDigit(splittedInput[i]))
                {
                    numbers += splittedInput[i];
                    continue;
                }

                else if (char.IsLetter(splittedInput[i]))
                {
                    text += splittedInput[i];
                    continue;
                }

                else
                {
                    symbol += splittedInput[i];
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(text);
            foreach (var item in symbol)
            {
                Console.Write(item);
            }
        }
    }
}
