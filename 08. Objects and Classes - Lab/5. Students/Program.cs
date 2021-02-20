using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }

                string[] commandARR = command.Split(" ");

                string firstName = commandARR[0];
                string lastName = commandARR[1];
                int ageName = int.Parse(commandARR[2]);
                string town = commandARR[3];

                Students student = new Students();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = ageName;
                student.HomeTown = town;

                students.Add(student);
            }

            string filterCity = Console.ReadLine();

            foreach (Students student in students)
            {
                if (filterCity==student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
