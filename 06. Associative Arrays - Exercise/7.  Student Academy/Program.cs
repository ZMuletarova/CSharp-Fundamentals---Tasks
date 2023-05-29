using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dic.ContainsKey(name))
                {
                    dic[name] = new List<double>();
                    dic[name].Add(grade);
                }
                else
                {
                    dic[name].Add(grade);
                }
            }

            var newDic = new Dictionary<string, double>();

            foreach (var item in dic)
            {
                double sumNotes = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    sumNotes += item.Value[i];
                }

                double averageNotes = sumNotes / item.Value.Count;

                if (averageNotes>=4.50)
                {
                    newDic[item.Key] = averageNotes;
                }
                else
                {
                    continue;
                }
            }

            var finalOne = newDic.OrderByDescending(x => x.Value).ToArray();

            foreach (var item in finalOne)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
