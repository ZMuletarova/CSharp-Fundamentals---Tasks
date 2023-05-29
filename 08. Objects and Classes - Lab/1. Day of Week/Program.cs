using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Object_and_Classes_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime day = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
