using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_TSORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfTestcases = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < noOfTestcases; i++)
            {
                values.Add(int.Parse(Console.ReadLine()));
            }
            values.Sort();
            for (int i = 0; i < noOfTestcases; i++)
            {
                output.Append(values[i]);
                if (i < noOfTestcases - 1)
                {
                    output.Append(Environment.NewLine);
                }
                
            }
            Console.WriteLine(output.ToString());
            //Console.ReadKey();
        }
    }
}
