using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_INTEST
{
    class Program
    {
        static int Main(string[] args)
        {
            int areDivisible = 0;
            string[] strValues = Console.ReadLine().Split(' ');
            int count = Int32.Parse(strValues[0]);
            int divisor = Int32.Parse(strValues[1]);

            for (int i = 0; i < count; i++)
            {
                if (Int32.Parse(Console.ReadLine()) % divisor == 0)
                {
                    areDivisible++;
                }
            }
            Console.WriteLine(areDivisible);
            return 0;
        }
    }
}
