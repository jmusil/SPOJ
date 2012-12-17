using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_LEBOMBS
{
    class Program
    {
        static int Main(string[] args)
        {
            int amountOfTestcases = Int32.Parse(Console.ReadLine());
            int amountOfHouses;
            char[] bombIndicatorsStrings;
            char[] explodedHouses;
            int count;
            while (amountOfTestcases-- > 0)
            {
                count = 0;
                amountOfHouses = Int32.Parse(Console.ReadLine());
                bombIndicatorsStrings = new char[amountOfHouses];
                bombIndicatorsStrings = Console.ReadLine().ToCharArray();
                explodedHouses = new char[amountOfHouses];

                if (bombIndicatorsStrings[0] == '1')
                {
                    explodedHouses[0] = 'X';
                    if (amountOfHouses > 1)
                    {
                        explodedHouses[1] = 'X';    
                    }
                    
                }
                else
                {
                    explodedHouses[0] = 'O';
                }
                if (bombIndicatorsStrings[amountOfHouses-1] == '1')
                {
                    explodedHouses[amountOfHouses - 1] = 'X';
                    if (amountOfHouses > 1)
                    {
                        explodedHouses[amountOfHouses - 2] = 'X';    
                    }
                }
                else if (explodedHouses[amountOfHouses -1] != 'X')
                {
                    explodedHouses[amountOfHouses -1] = 'O';
                }

                for (int i = 1; i < amountOfHouses - 1; i++)
                {
                    if (bombIndicatorsStrings[i] == '1')
                    {
                        explodedHouses[i] = 'X';
                        explodedHouses[i - 1] = 'X';
                        explodedHouses[i + 1] = 'X';
                    }
                    else if (explodedHouses[i] != 'X')
                    {
                        explodedHouses[i] = 'O';
                    }

                }
                foreach (char kchar in explodedHouses)
                {
                    if (kchar == 'O') count++;
                }
                Console.WriteLine(count);
            }
            return 0;
        }
    }
}
