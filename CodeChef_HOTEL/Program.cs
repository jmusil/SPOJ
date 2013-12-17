using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_HOTEL
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = Int32.Parse(Console.ReadLine());
            while (testcase-- > 0)
            {
                Console.ReadLine();
                int[] arrivals = Console.ReadLine().Split(' ').Select(i => Int32.Parse(i)).ToArray();
                int[] departures = Console.ReadLine().Split(' ').Select(i => Int32.Parse(i)).ToArray();
                int[] guestsPresent = new int[1000]; 

                for (int i = 0; i < arrivals.Length; i++)
                {
                    int start = arrivals[i];
                    int end = departures[i];

                    for (int j = start; j < end; j++)
                    {
                        guestsPresent[j]++;
                    }
                }
                Console.WriteLine(guestsPresent.Max());
            }
        }
    }
}
