using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SPOJ24_FCTRL2
{
    class Program
    {
        static int Main(string[] args)
        {
            UInt64 amountOfNumbers = Convert.ToUInt64(Console.ReadLine());
            Decimal[] numbers = new Decimal[amountOfNumbers];

            for (UInt64 i = 0; i < amountOfNumbers; i++)
            {
                numbers[i] = Convert.ToDecimal(Console.ReadLine());
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(Math.Truncate(Factorial(number)));
            }
            Console.WriteLine(UInt64.MaxValue.ToString());
            Console.WriteLine(Double.MaxValue.ToString());
            Console.WriteLine(Decimal.MaxValue.ToString());
            Console.WriteLine(long.MaxValue.ToString());
            Console.ReadKey();
            return 0;
        }

        static Decimal Factorial(Decimal input)
        {
            if (input == 0)
	        {
		        return 1;
	        } else
	        {
                return input * Factorial(input - 1);
	        }
        }
    }
}
