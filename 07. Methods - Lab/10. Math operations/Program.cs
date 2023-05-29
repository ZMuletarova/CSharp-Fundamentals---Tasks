using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double number2 = double.Parse(Console.ReadLine());

            if (symbol == "+")
            {
                double area = Add(number1, number2);
                Console.WriteLine(area);
            }
            else if (symbol == "-")
            {
                double area = Subtract(number1, number2);
                Console.WriteLine(area);
            }
            else if (symbol == "*")
            {
                double area = Multiplication(number1, number2);
                Console.WriteLine(area);
            }
            else if (symbol == "/")
            {
                double area = Divide(number1, number2);
                Console.WriteLine(area);
            }
        }

        static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
