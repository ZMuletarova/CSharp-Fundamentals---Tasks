using System;
using System.Linq;
using System.Collections.Generic;


namespace _3._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int countDefend = 0;
            int countFire = 0;

            ushort maxHeatlth = ushort.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="Retire")
                {
                    break;
                }

                string[] commandARR = command.Split(" ");

                if (commandARR[0]=="Fire")
                {
                   int indexNumber = int.Parse(commandARR[1]);
                   int damage = int.Parse(commandARR[2]);

                    if (indexNumber>=0 && indexNumber<warShip.Count)
                    {
                        for (int i = 0; i < warShip.Count; i++)
                        {
                            if (i==indexNumber)
                            {
                                warShip[i] -= damage;

                                if (warShip[i]<=0)
                                {
                                    Console.WriteLine("You won! The enemy ship has sunken.");
                                    countFire++;
                                    return;
                                    
                                }
                            }
                        }
                    }
                }

                else if (commandARR[0] == "Defend")
                {
                    int startIndex = int.Parse(commandARR[1]);
                    int endIndex = int.Parse(commandARR[2]);
                    ushort damage = ushort.Parse(commandARR[3]);

                    if (startIndex>=0 && startIndex<pirateShip.Count-1 && endIndex<pirateShip.Count && endIndex>0)
                    {
                        if (startIndex<endIndex)
                        {
                            for (int i = 0; i < pirateShip.Count; i++)
                            {
                                if (i == startIndex)
                                {
                                    for (int j = startIndex; j <= endIndex; j++)
                                    {
                                        pirateShip[j] -= damage;
                                        if (pirateShip[j] <= 0)
                                        {
                                            Console.WriteLine("You lost! The pirate ship has sunken.");
                                            countDefend++;
                                            return;

                                        }
                                    }
                                }
                            }
                        }
                    }
                }


                else if (commandARR[0] == "Repair")
                {
                    int indexNumber = int.Parse(commandARR[1]);
                    int health = int.Parse(commandARR[2]);

                    if (indexNumber>=0 && indexNumber<pirateShip.Count)
                    {
                        for (int i = 0; i < pirateShip.Count; i++)
                        {
                            if (indexNumber==i)
                            {
                                if (pirateShip[i] + health>=maxHeatlth)
                                {
                                    pirateShip[i] = maxHeatlth;
                                }

                                else
                                {
                                    pirateShip[i] += health;
                                    break;
                                }
                            }
                        }
                    }
                }


                else if (commandARR[0] == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i]<0.2*maxHeatlth)
                        {
                            count++;
                        }
                    }

                    if (count>0)
                    {
                        Console.WriteLine($"{count} sections need repair.");
                    }
                }
            }


            int sumPirate = 0;
            int sumWar = 0;

            if (countDefend<=0 && countFire<=0)
            {
                for (int i = 0; i < pirateShip.Count; i++)
                {
                    sumPirate += pirateShip[i];
                }

                Console.WriteLine($"Pirate ship status: {sumPirate}");

                for (int i = 0; i < warShip.Count; i++)
                {
                    sumWar += warShip[i];
                }

                Console.WriteLine($"Warship status: {sumWar}");
            }
        }
    }
}
