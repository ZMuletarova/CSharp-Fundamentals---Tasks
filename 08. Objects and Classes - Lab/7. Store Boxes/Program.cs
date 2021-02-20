using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;

namespace _7._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                string[] inputInfo = input.Split(" ");
                string serialNumber = inputInfo[0];
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice = decimal.Parse(inputInfo[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice; 

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.Item = item;

                boxes.Add(box);
            }

            
            foreach (Box box in boxes.OrderByDescending(x=>x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}
