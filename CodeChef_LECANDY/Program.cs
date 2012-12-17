using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_LECANDY
{
    class Program
    {
        static int Main(string[] args)
        {
            int numberOfTestcases = Int32.Parse(Console.ReadLine());
            string[] input;
            string[] candyRequests;
            int[] candyRequestsInts;
            int numberOfElephants;
            int numberOfCandys;
            int totalCandysRequested;
            int candyRequestsLength;

            while (numberOfTestcases-- > 0)
            {
                input = Console.ReadLine().Split(' ');
                numberOfElephants = Int32.Parse(input[0]);
                numberOfCandys = Int32.Parse(input[1]);
                candyRequests = Console.ReadLine().Split(' ');
                candyRequestsLength = candyRequests.Length;

                candyRequestsInts = new int[candyRequestsLength];

                for (int i = 0; i < candyRequestsLength; i++)
                {
                    candyRequestsInts[i] = Int32.Parse(candyRequests[i]);
                }
                totalCandysRequested = candyRequestsInts.Sum();
                if (totalCandysRequested > numberOfCandys)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            Console.ReadKey();
            return 0;
        }
    }
}
