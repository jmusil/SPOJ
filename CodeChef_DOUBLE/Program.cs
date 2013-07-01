using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeChef_DOUBLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            int length;
            while (testcases-- > 0)
            {
                length = Int32.Parse(Console.ReadLine());
                if (length == 0)
                {
                    Console.WriteLine(0);
                }
                else if (length % 2 == 0)
                {
                    Console.WriteLine(length);
                }
                else
                {
                    Console.WriteLine(length - 1);
                }
            }
        }
    }
}
