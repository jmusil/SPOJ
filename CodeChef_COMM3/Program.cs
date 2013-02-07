using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_COMM3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDistance;
            int numberOfTestcases = Int32.Parse(Console.ReadLine());
            string[] pointA;
            string[] pointB;
            string[] pointC;
            int[] pointIntA = new int[2];
            int[] pointIntB = new int[2];
            int[] pointIntC = new int[2];
            int passed;

            while (numberOfTestcases-- > 0)
            {
                passed = 0;
                maxDistance = Int32.Parse(Console.ReadLine());
                pointA = Console.ReadLine().Split(' ');
                pointB = Console.ReadLine().Split(' ');
                pointC = Console.ReadLine().Split(' ');
                pointIntA[0] = Int32.Parse(pointA[0]);
                pointIntA[1] = Int32.Parse(pointA[1]);
                pointIntB[0] = Int32.Parse(pointB[0]);
                pointIntB[1] = Int32.Parse(pointB[1]);
                pointIntC[0] = Int32.Parse(pointC[0]);
                pointIntC[1] = Int32.Parse(pointC[1]);

                if (isInRange(pointIntA[0], pointIntA[1], pointIntB[0], pointIntB[1], maxDistance))
                {
                    passed++;
                }
                if (isInRange(pointIntB[0], pointIntB[1], pointIntC[0], pointIntC[1], maxDistance))
                {
                    passed++;
                }
                if (isInRange(pointIntC[0], pointIntC[1], pointIntA[0], pointIntA[1], maxDistance))
                {
                    passed++;
                }
                if (passed > 1)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

            }

        }

        static bool isInRange(int x1, int y1, int x2, int y2, int range)
        {
            if (getDistance(x1, y1, x2, y2) <= range * range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double getDistance(int x1, int y1, int x2, int y2)
        {
            //return Math.Sqrt(Math.Pow(Math.Max(x1, x2) - Math.Min(x1, x2),2) + Math.Pow(Math.Max(y1, y2) - Math.Min(y1, y2),2));
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

    }
}
