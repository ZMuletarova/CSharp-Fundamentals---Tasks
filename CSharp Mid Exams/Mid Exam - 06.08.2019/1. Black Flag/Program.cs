using System;

namespace Mid_Exam_06._08._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            decimal expectedPlunder = decimal.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 1; i <= daysPlunder; i++)
            {
                sum += dailyPlunder;

                if (i % 3 == 0)
                {
                    sum += dailyPlunder / 2M;
                }
                if (i % 5 == 0)
                {
                    sum -=sum*0.3M;
                }
            }

            if (sum>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                decimal procent = (sum / expectedPlunder * 100M);
                Console.WriteLine($"Collected only {procent:f2}% of the plunder.");
            }
        }
    }
}
