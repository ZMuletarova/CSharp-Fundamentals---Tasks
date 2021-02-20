using System;
using System.Linq;
using System.Collections.Generic;


namespace Mid_Exam_10._12._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTheJourney = double.Parse(Console.ReadLine());
            int numberOfMonth = int.Parse(Console.ReadLine());
            double savedMoney = 0;
            double forEachMonth = moneyForTheJourney * 0.25;

            for (int i = 1; i <= numberOfMonth; i++)
            {
                if (i%2!=0 && i>1)
                {
                    savedMoney = savedMoney * 0.84 + forEachMonth;
                    continue;
                }

                if (i%4==0)
                {
                    savedMoney += savedMoney * 0.25 + forEachMonth;
                    continue;
                }

                else
                {
                    savedMoney += forEachMonth;
                }
            }

            if (savedMoney>moneyForTheJourney)
            {
                double diff = savedMoney - moneyForTheJourney;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {diff:f2}lv. for souvenirs.");
            }

            else
            {
                double diff2 = moneyForTheJourney - savedMoney;
                Console.WriteLine($"Sorry. You need {diff2:f2}lv. more.");
            }
        }
    }
}
