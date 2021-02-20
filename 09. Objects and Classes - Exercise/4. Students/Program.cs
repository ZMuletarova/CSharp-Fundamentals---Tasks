using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Students> finalList = new List<Students>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                Students student = new Students(input[0], input[1], decimal.Parse(input[2]));
                finalList.Add(student);
            }

            //finalList.OrderBy(s => s.Grade);

            //Console.Write(string.Join("\n", finalList));
            List<Students> final = finalList.OrderByDescending(s => s.Grade).ToList();
            Console.Write(string.Join("\n", final));
        }
    }

    class Students
    {
        public Students(string firstName, string secondName, decimal grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public decimal Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade}";
        }
    }
}
