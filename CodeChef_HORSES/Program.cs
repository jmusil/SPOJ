using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_HORSES
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            while (testcases-- > 0)
            {
                int horseCount = Int32.Parse(Console.ReadLine());
                
                int diff = 0;
                List<int> skills = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToList();
                skills.Sort();
                skills.Reverse();
                int min = skills[0];
                for (int i = 0; i < skills.Count - 1; i++)
                {
                    diff = skills[i] - skills[i + 1];
                    if (diff < min)
                    {
                        min = diff;
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
