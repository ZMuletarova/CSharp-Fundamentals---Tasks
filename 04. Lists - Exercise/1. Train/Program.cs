using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityEachWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    var splittedInput = input.Split();

                    if (splittedInput[0] == "Add")
                    {
                        int addNumberVagoons = int.Parse(splittedInput[1]);
                        wagons.Add(addNumberVagoons);
                    }
                    else
                    {
                        string addPassengers = splittedInput[0];
                        int addPassengersToVagoons = int.Parse(addPassengers);

                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (addPassengersToVagoons + wagons[i] <= maxCapacityEachWagon)
                            {
                                wagons[i] += addPassengersToVagoons;
                                break;
                            }

                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < wagons.Count; i++)
            {
                Console.Write(wagons[i] + " ");
            }
        }
    }
}
