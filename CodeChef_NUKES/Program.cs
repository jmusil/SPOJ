using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_NUKES
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            Int64 numberOfParticles = Int64.Parse(input[0]);
            int treshold = Int32.Parse(input[1]);
            int numberOfChambers = Int32.Parse(input[2]);
            int[] chamberValue = new int[numberOfChambers];
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numberOfChambers; i++)
            {
                chamberValue[i] = (int)(numberOfParticles % (Convert.ToInt64(treshold) + Convert.ToInt64(1)));
                numberOfParticles = numberOfParticles / (long)(treshold + 1);
            }




            foreach (int value in chamberValue)
            {
                output.Append(value);

                output.Append(' ');
            }
            Console.WriteLine(output.ToString());

        }
    }
}
