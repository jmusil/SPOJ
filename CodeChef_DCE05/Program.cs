using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_DCE05
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfTestcases = int.Parse(Console.ReadLine());
            int num;
            while (noOfTestcases > 0)
            {
                int testcase = int.Parse(Console.ReadLine());
                num = 1;
                while (num <= testcase)
                {
                    num <<= 1;
                }
                Console.WriteLine(num >> 1);
                noOfTestcases--;
            }
            Console.ReadKey();
        }
    }
}
