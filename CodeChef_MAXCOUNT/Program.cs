using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeChef_MAXCOUNT
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            int valuesAmount;
            List<int> values = new List<int>();
            List<int> mostFrequent = new List<int>();
            int mostFrequentCount;
            int mostFrequentMin;

            while (testcases-- > 0)
            {
                values.Clear();
                valuesAmount = Int32.Parse(Console.ReadLine());
                values = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToList();
                var appearances = values.GroupBy(i => i) //groups by distinct values
                    .OrderByDescending(grp => grp.Count()).ThenBy(grp => grp.Min())//orders by no. of appearances, then by values
                    .Select(grp => new { Num = grp.Key, Count = grp.Count() });// 

                mostFrequentCount = appearances.First().Count;
                mostFrequentMin = appearances.First().Num;

                Console.WriteLine(mostFrequentMin + " " + mostFrequentCount);
            }
        }
    }
}
