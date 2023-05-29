using System;
using System.Linq;
namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNumbers = 0;
            int oddNumbers = 0;
            int diffNumbers = 0;

            for (int i = 0;  i <numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    evenNumbers += numbers[i];
                }
                else
                {
                    oddNumbers += numbers[i];
                }
            }

            diffNumbers = evenNumbers - oddNumbers;
            Console.WriteLine(diffNumbers);
        }
    }
}
