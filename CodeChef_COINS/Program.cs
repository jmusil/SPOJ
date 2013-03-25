using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_COINS
{
    class Program
    {
        static Dictionary<Int64, Int64> memoizedResults = new Dictionary<Int64, Int64>();
        static Int64 temp;
        static void Main(string[] args)
        {
            Int64 input;
            Int64 converted;
            
            for (int i = 0; i < 10; i++)
            {
                input = Int32.Parse(Console.ReadLine());
                converted = getMax(input);
                if (converted > input)
                {
                    Console.WriteLine(converted);
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
        }

        static Int64 getMax(Int64 value)
        {
            if (value == 0)
            {
                return 0;
            }
            if (memoizedResults.ContainsKey(value))
            {
                temp =  memoizedResults[value];
            }
            else
            {
                temp = (getMax(value / 2) + getMax(value / 3) + getMax(value / 4));
                memoizedResults.Add(value, temp);
            }

            if (value < temp)
            {
                return temp;
            }
            else
            {
                return value;
            }
        }
    }
}
