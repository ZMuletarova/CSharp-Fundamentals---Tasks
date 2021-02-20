using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name=="add")
            {
                add();
            }

            else if (name=="multiply")
            {
                multiply();
            }

            else if (name=="subtract")
            {
                subtract();
            }

            else if (name=="divide")
            {
                divide();
            }
        }

        static void add()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;

            Console.WriteLine(sum);
        }

        static void multiply()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 *number2;

            Console.WriteLine(sum);
        }

        static void subtract()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 - number2;

            Console.WriteLine(sum);
        }

        static void divide()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 / number2;

            Console.WriteLine(sum);
        }
    }
}
