using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_BUYING2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestcases = Int32.Parse(Console.ReadLine());
            string[] banknotesAndPrice = new string[2];
            int moneyTotal;
            int numberOfCandys;
            int remainder;
            while (numberOfTestcases-- > 0)
            {
                banknotesAndPrice = Console.ReadLine().Split(' ');
                int[] banknotes = new int[Int32.Parse(banknotesAndPrice[0])];
                int pricePerCandy = Int32.Parse(banknotesAndPrice[1]);
                string[] banknotesInput = Console.ReadLine().Split(' ');
                for (int i = 0; i < banknotes.Length; i++)
                {
                    banknotes[i] = Int32.Parse(banknotesInput[i]);
                }
                moneyTotal = banknotes.Sum();
                numberOfCandys = moneyTotal / pricePerCandy;
                remainder = moneyTotal % pricePerCandy;
                if (remainder >= banknotes.Min())
                {
                    numberOfCandys = -1;
                }
                Console.WriteLine(numberOfCandys);
            }
        }
    }
}
