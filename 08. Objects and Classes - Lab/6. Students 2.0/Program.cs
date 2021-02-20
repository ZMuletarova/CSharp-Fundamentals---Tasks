using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _6._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end")
                {
                    break;
                }

                string[] splittedInput = command.Split(" ");
                string firstName = splittedInput[0];
                string lastName = splittedInput[1];
                int age = int.Parse(splittedInput[2]);
                string town = splittedInput[3];

                if (IsExisting(students,firstName,lastName))
                {
                    Student student = GetStudent(students, firstName, lastName, age);
                }

                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Town = town;

                    students.Add(student);
                }
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (filterCity==student.Town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }

            }
            return false;
        }


        static Student GetStudent(List<Student> students, string firstName, string lastName, int age)
        {
            Student exisiting = null;
            foreach (Student student in students)
            {

                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    exisiting = student;
                    exisiting.Age = age;
                }
            }

            return exisiting;
        }
    }
}


