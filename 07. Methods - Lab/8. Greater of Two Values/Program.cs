using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Greater();
        }

        static void Greater()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());

                if (numberOne>numberTwo)
                {
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberTwo);
                }
            }

            else if (type == "char")
            {
                char numberOne = char.Parse(Console.ReadLine());
                char numberTwo = char.Parse(Console.ReadLine());

                int newOne = (int)(numberOne);
                int newTwo = (int)(numberTwo);

                if (newOne>newTwo)
                {
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberTwo);
                }
            }

            else if (type =="string")
            {
                int currenSumOne = 0;
                int currenSumTwo = 0;

                string numberOne = Console.ReadLine();

                string[] newNumberOne = numberOne.Split();

                for (int i = 0; i < newNumberOne.Length; i++)
                {
                     currenSumOne =+ (int)(i);
                }

                string numberTwo = Console.ReadLine();

                string[] newNumberTwo = numberTwo.Split();

                for (int i = 0; i < newNumberTwo.Length; i++)
                {
                    currenSumTwo = +(int)(i);
                }

                if (currenSumOne > currenSumTwo)
                {
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberTwo);
                }
            }
        }
    }
}
