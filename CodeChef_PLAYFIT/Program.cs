using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_PLAYFIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            while (testcases-- > 0)
            {
                Console.ReadLine();
                int[] goals = Console.ReadLine().Split(' ').Select(i => Int32.Parse(i)).ToArray();
                int[] min = new int[goals.Length];
                int[] max = new int[goals.Length];
                int[] diffs = new int[goals.Length];

                min[0] = goals[0];
                for (int i = 1; i < goals.Length; i++)
                {
                    if (goals[i] < min[i-1])
                    {
                        min[i] = goals[i];
                    }
                    else
                    {
                        min[i] = min[i - 1];
                    }
                }
                max[goals.Length - 1] = goals[goals.Length - 1];
                for (int i = goals.Length - 2; i >= 0 ; i--)
                {
                    if (goals[i] > max[i + 1])
                    {
                        max[i] = goals[i];
                    }
                    else
                    {
                        max[i] = max[i + 1];
                    }
                }
                for (int i = 0; i < goals.Length -1; i++)
                {
                    diffs[i] = max[i + 1] - min[i];
                }

                int bestImprovement = diffs.Max();

                if (bestImprovement > 0)
                {
                    Console.WriteLine(bestImprovement);
                }
                else
                {
                    Console.WriteLine("UNFIT");
                }
            }
        }
    }
}
