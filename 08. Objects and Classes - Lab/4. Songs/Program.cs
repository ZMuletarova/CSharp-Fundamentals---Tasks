using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<TypeOfSongs> songs = new List<TypeOfSongs>();

            for (int i = 0; i < number; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                TypeOfSongs song = new TypeOfSongs();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList =="all")
            {
                foreach (TypeOfSongs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (TypeOfSongs song in songs)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
