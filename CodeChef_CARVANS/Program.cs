using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_CARVANS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations
            int testcases = Int32.Parse(Console.ReadLine());
            int cars;
            string input;            
            int[] speed;
            int speedlimit;
            int maxSpeedCars;
            #endregion

            for (int i = 0; i < testcases; i++)
            {
                maxSpeedCars = 1;
                cars = Int32.Parse(Console.ReadLine());
                input = Console.ReadLine();
                
                speed = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                speedlimit = speed[0];
                for (int j = 1; j < speed.Length; j++)
                {
                    if (speed[j] <= speedlimit)
                    {
                        speedlimit = speed[j];
                        maxSpeedCars++;
                    }
                }
                Console.WriteLine(maxSpeedCars);
            }
 
        }
    }
}
