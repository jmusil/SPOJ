using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SPOJ11_FCTRL
{
    class Program
    {
        static int Main(string[] args)
        {
            UInt64 amountOfNumbers = Convert.ToUInt64(Console.ReadLine());
            UInt64[] numbers = new UInt64[amountOfNumbers];

            for (UInt64 i = 0; i < amountOfNumbers; i++)
            {
                numbers[i] = Convert.ToUInt64(Console.ReadLine());
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(getNumberOfTrailingZeroes(number));
            }

            return 0;
        }

        static UInt64 getNumberOfTrailingZeroes(UInt64 input)
        {
            UInt64 zeroes = 0;
            double result = input;
            while (result >= 1)
            {
                result = result / 5;
                if (result >= 1)
                {
                    zeroes += (UInt64)Math.Truncate(result);
                }
            }
            return zeroes;
        }
    }
}
