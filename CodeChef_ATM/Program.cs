using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_ATM
{
    class Program
    {
        static int Main(string[] args)
        {

            decimal[] values = new decimal[2];
            string[] strValues = Console.ReadLine().Split(' ');
            values[0] = decimal.Parse(strValues[0]);
            values[1] = decimal.Parse(strValues[1]);

            if ((values[0] + 0.5m) > values[1] || values[0] % 5m != 0)
            {
                Console.WriteLine("{0:F2}", values[1]);
            }
            else
            {
                Console.WriteLine("{0:F2}", values[1] - values[0] - 0.5m);
            }
            Console.ReadKey();
            return 0;
        }
    }
}
