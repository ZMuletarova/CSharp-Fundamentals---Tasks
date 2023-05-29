using System;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            var numberOfPeople = new int[countOfWagons];
            int sumOfPeople = 0;

            for (int i = 0; i < countOfWagons; i++)
            {
                int newPerson = int.Parse(Console.ReadLine());
                numberOfPeople[i] = newPerson;
                sumOfPeople += newPerson;
            }

            for (int i = 0; i <=countOfWagons-1; i++)
            {
                Console.Write(numberOfPeople[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }
    }
}
