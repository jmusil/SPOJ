using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_TLG
{
    class Program
    {
        static int Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            int lead = 0;
            int totalScoreP1 = 0;
            int totalScoreP2 = 0;
            while (testcases > 0)
            {
                string input = Console.ReadLine();
                string[] strValues = new string[2];
                int[] intValues = new int[2];
                strValues = input.Split(' ');
                
                intValues[0] = Convert.ToInt32(strValues[0]) + totalScoreP1;
                intValues[1] = Convert.ToInt32(strValues[1]) + totalScoreP2;

                totalScoreP1 = intValues[0];
                totalScoreP2 = intValues[1];

                if (Math.Abs((intValues[0] - intValues[1])) > Math.Abs(lead))
                {
                    lead = intValues[0] - intValues[1];
                }
                testcases--;
            }

            if (lead > 0)
            {
                Console.WriteLine("1 " + Math.Abs(lead));
            }
            else
            {
                Console.WriteLine("2 " + Math.Abs(lead));
            }
            return 0;
        }
    }
}
