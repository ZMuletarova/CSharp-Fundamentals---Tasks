using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d{2}(\W)[A-Za-z]{3}\1[0-9]{4}");


            //Match match = regex.Match(@"13/Feb.2020, 13/Feb/2020, 13-Feb-2020, 13*Feb*2020");

            ////foreach (Match item in matches)
            ////{
            //    Console.WriteLine(match);
            //    Console.WriteLine(match.Groups[1].Value);
            ////}
            ///---->>> vrashta samo parvata data i spira
            ///

            MatchCollection matches = regex.Matches(@"13/Feb.2020, 13/Feb/2020, 13-Feb-2020, 13*Feb*2020");

            //int count = matches.Count;
            //Console.WriteLine(count);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Groups[1].Value);
            }

            //--->> vrashta vsichki shodni dati (collections)
        }
    }
}
