using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_MARCHA1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            string[] input;
            int banknotesAmount;
            int requestedMoney;
            int[] banknotes;
            int index;
            int sumSoFar;
            while (testCases-- > 0)
            {
                index = 0;
                sumSoFar = 0;
                input = Console.ReadLine().Split(' ');
                banknotesAmount = Int32.Parse(input[0]);
                requestedMoney = Int32.Parse(input[1]);
                banknotes = new int[banknotesAmount];
                for (int i = 0; i < banknotesAmount; i++)
                {
                    banknotes[i] = Int32.Parse(Console.ReadLine());
                }
                if (CanBePaid(banknotes, index, sumSoFar, requestedMoney))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
        }

        static bool CanBePaid(int[] banknotes, int index, int sumSoFar, int amountToBePaid)
        {
            //the final condition that ends recursion - we've hit the needed amount of money
            if (sumSoFar == amountToBePaid)
            {
                return true;
            }
            // wrong way, it exceeds the needed amount of money or the end of the array was reached
            if (sumSoFar > amountToBePaid || index == banknotes.Length)
            {
                return false;
            }
            // check if it's payable, either by using actual banknote or not
            return (CanBePaid(banknotes, index + 1, sumSoFar + banknotes[index], amountToBePaid) || CanBePaid(banknotes, index + 1, sumSoFar, amountToBePaid));
        }
   }
}
