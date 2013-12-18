using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_SPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            while (testcases-- > 0)
            {
                bool spoon = false;
                int[] dimensions = Console.ReadLine().Split(' ').Select(i => Int32.Parse(i)).ToArray();
                List<string> input = new List<string>();
                for (int i = 0; i < dimensions[0]; i++)
                {
                    input.Add(Console.ReadLine());
                }
                //get vertical strings
                List<string> verticals = new List<string>();
                for (int j = 0; j < dimensions[1]; j++)
                {
                    StringBuilder newString = new StringBuilder();
                    foreach (string horizontalString in input)
                    {
                        newString.Append(horizontalString[j]);
                    }
                    verticals.Add(newString.ToString());
                }

                input.AddRange(verticals);
                
                foreach (var line in input)
                {
                    if (line.ToLower().Contains("spoon"))
                    {
                        spoon = true;
                    }
                }

                if (spoon)
                {
                    Console.WriteLine("There is a spoon!");
                }
                else
                {
                    Console.WriteLine("There is indeed no spoon!");
                }
            }
        }
    }
}
