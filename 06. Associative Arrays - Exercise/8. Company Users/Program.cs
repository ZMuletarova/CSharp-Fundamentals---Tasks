using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }

                string[] splittedInput = input.Split(" -> ").ToArray();
                string companyName = splittedInput[0];
                string employeeId = splittedInput[1];


                if (!dic.ContainsKey(companyName))
                {
                    dic[companyName] = new List<string>();
                    dic[companyName].Add(employeeId);
                }

                else
                {
                    int count = 0;

                    foreach (var item in dic)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            if (splittedInput[1]==item.Value[i])
                            {
                                count++;
                                break;
                            }
                        }
                    }

                    if (count==0)
                    {
                        dic[companyName].Add(employeeId);
                    }

                    else
                    {
                        continue;
                    }
                }
            }

            var newOne = dic.OrderBy(x => x.Key).ToArray();

            foreach (var item in newOne)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value)}");
            }
        }
    }
}
