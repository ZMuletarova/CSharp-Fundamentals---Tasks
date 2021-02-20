using System;

namespace Objects_and_Classes_UPR
{
    class Program
    {
        static void Main(string[] args)
        {

            Random newRandom = new Random();

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great" };
            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int phrasesIndex = newRandom.Next(0, phrases.Length);
                int eventIndex = newRandom.Next(0, events.Length);
                int authorsIndex = newRandom.Next(0, authors.Length);
                int citiesIndex = newRandom.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventIndex]} {authors[authorsIndex]} – {cities[citiesIndex]}.");
            }







        }


    }

}
