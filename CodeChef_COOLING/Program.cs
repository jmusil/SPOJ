using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_COOLING
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            int racksAmount;
            string[] racksInput;
            string[] piesInput;
            List<int> racks;
            List<int> pies;
            int count;
            
            while (testCases-- > 0)
            {
                count = 0;
                racksAmount = Int32.Parse(Console.ReadLine());
                piesInput = Console.ReadLine().Split(' ');
                racksInput = Console.ReadLine().Split(' ');
                pies = new List<int>();
                racks = new List<int>();
                for (int i = 0; i < piesInput.Length; i++)
                {
                    pies.Add(Int32.Parse(piesInput[i]));
                    racks.Add(Int32.Parse(racksInput[i]));
                }
                pies.Sort();
                racks.Sort();
                while (pies.Count > 0)
                {
                    if (pies.Max() > racks.Max())
                    {
                        pies.Remove(pies.Max());
                    }
                    else
                    {
                        pies.Remove(pies.Max());
                        racks.Remove(racks.Max());
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
