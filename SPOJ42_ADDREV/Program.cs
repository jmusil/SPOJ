using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPOJ42_ADDREV
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt64 param = 0;
            string input = "a";
            bool firstRun = true;
            while ((input = Console.ReadLine()) != null)
            {
                if (firstRun == false)
                {
                    string[] two_ints = input.Split(' ');

                    UInt64[] numbers = new UInt64[2];
                    numbers[0] = UInt64.Parse(two_ints[0]);
                    numbers[1] = UInt64.Parse(two_ints[1]);

                    Console.WriteLine(reverseNumber(reverseNumber(numbers[0]) + reverseNumber(numbers[1])));    
                }
                firstRun = false;
            }
        }

        static UInt64 reverseNumber(UInt64 number)
        {
            string temp = number.ToString();
            string reversed_temp = new string(temp.ToCharArray().Reverse().ToArray());
            return UInt64.Parse(reversed_temp);
        }
        
    }
}
