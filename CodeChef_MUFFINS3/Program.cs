using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_MUFFINS3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestcases = Int32.Parse(Console.ReadLine());

            while (numberOfTestcases-- > 0)
            {
                Console.WriteLine(Int32.Parse(Console.ReadLine())/2+1);
            }
        }
    }
}
