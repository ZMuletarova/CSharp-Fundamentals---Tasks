using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string bomb = " ";
            int finalBomb = 0;
            int finalBombReserved = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '>')
                {
                    bomb = input[i + 1].ToString();
                    finalBomb = int.Parse(bomb) + finalBombReserved;

                    for (int j = 0; j < finalBomb; j++)
                    {
                        if (input[i + 1] != '>')
                        {
                            input = input.Remove(i + 1, 1);

                        }
                        else
                        {
                            finalBombReserved++;

                            if (finalBombReserved >= 2)
                            {
                                i++;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(input);
        }
    }
}
