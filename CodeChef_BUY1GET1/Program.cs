using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_BUY1GET1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            while (testcases-- > 0)
            {
                string input = Console.ReadLine();
                int cost = 0;
                Dictionary<char, int> dict = new Dictionary<char, int>();
                foreach (char item in input)
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 1);
                    }
                }

                foreach (var item in dict)
                {
                    cost += CalculateCost(item);
                }
                Console.WriteLine(cost);
            }
        }

        private static int CalculateCost(KeyValuePair<char, int> item)
        {
            return item.Value % 2 + item.Value / 2;
        }
    }
}
