using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();

            while (true)
            {
                string item = Console.ReadLine();

                if (item == "stop")
                {
                    break;
                }

                int itemQuantity = int.Parse(Console.ReadLine());
               
                if (!dic.ContainsKey(item))
                {
                    dic[item] = itemQuantity;
                }

                else
                {
                    dic[item] += itemQuantity;
                }
            }

            foreach (var current in dic)
            {
                Console.WriteLine($"{current.Key} -> {current.Value}");
            }
        }
    }
}
