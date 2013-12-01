using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_CIELAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(i => Int32.Parse(i)).ToArray();
            
            int result = input[0] - input[1];
            if (result % 10 == 9)
            {
                result = result - 1;
            }
            else
            {
                result = result + 1;
            }

            Console.WriteLine(result);
        }
    }
}
