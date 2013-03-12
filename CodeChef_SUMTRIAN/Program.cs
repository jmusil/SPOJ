using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_SUMTRIAN
{
    class Program
    {
        static int Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            int lines;
            int[][] triangle;
            string[] line;
            int l, r;
            while (testCases-- > 0)
            {
                lines = Int32.Parse(Console.ReadLine());
                triangle = new int[lines][];
                for (int i = 0; i < lines; i++)
                {
                    line = Console.ReadLine().Split(' ');
                    triangle[i] = new int[i + 1];
                    for (int j = 0; j < i + 1; j++)
                    {
                        triangle[i][j] = Int32.Parse(line[j]);
                    }
                }

                for (int i = lines - 2; i >= 0; i--)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        l = triangle[i + 1][j];
                        r = triangle[i + 1][j + 1];

                        triangle[i][j] += l > r ? l : r;
                    }

                }

                Console.WriteLine(triangle[0][0]);
            }
            return 0;
        }
    }
}
