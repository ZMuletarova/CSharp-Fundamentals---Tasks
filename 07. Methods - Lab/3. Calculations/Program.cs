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
                Add();
            }
            else if (name=="multiply")
            {
                Multiply();
            }
            else if (name=="subtract")
            {
                Subtract();
            }
            else if (name=="divide")
            {
                Divide();
            }
        }

        static void Add()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;

            Console.WriteLine(sum);
        }

        static void Multiply()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 *number2;

            Console.WriteLine(sum);
        }

        static void Subtract()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 - number2;

            Console.WriteLine(sum);
        }

        static void Divide()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 / number2;

            Console.WriteLine(sum);
        }
    }
}
