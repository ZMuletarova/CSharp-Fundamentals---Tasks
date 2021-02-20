using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\+359(-| )[0-9]{1}\1[0-9]{3}\1[0-9]{4}\b");

            MatchCollection numbers = regex.Matches(input);

            int count = 0;

            foreach (Match number in numbers)
            {
                if (count >= numbers.Count - 1)
                {
                    Console.WriteLine(number.Value);
                    break;
                }

                Console.Write(number.Value + ", ");
                count++;


            }
        }
    }
}
