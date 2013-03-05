using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_CONFLIP
{
    class Program
    {
        static int Main(string[] args)
        {
            int numberOfTestcases = Int32.Parse(Console.ReadLine());
            int numberOfGames;
            string[] input;
            int initialFace;
            Int64 numberOfCoins;
            int faceToCheck;
            

            while (numberOfTestcases-- > 0)
            {
                numberOfGames = Int32.Parse(Console.ReadLine());
                while (numberOfGames-- > 0)
                {
                    input = Console.ReadLine().Split(' ');
                    initialFace = (Int32.Parse(input[0]) == 1) ? 1 : -1;
                    numberOfCoins = Int64.Parse(input[1]);
                    faceToCheck = (Int32.Parse(input[2]) == 1) ? 1 : -1;
                    
                    if (numberOfCoins % 2 == 0 || initialFace == faceToCheck)
                    {
                        Console.WriteLine(numberOfCoins / 2);
                    }
                    else
                    {
                        Console.WriteLine(numberOfCoins / 2 + 1);
                    }
                }
            }
            return 0;
        }
    }
}
