using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeChef_Points
{
    public struct Point
    {
        public int posX, posY;

        public Point(int x, int y)
        {
            posX = x;
            posY = y;
        }
    }

    public class myPointComparer : IComparer<Point>
    {

        public int Compare(Point a, Point b)
        {

            int xValueComparison = a.posX.CompareTo(b.posX) * -1;//invert sorting by x
            if (xValueComparison == 0)
            {
                return a.posY.CompareTo(b.posY);
            }
            else
            {
                return xValueComparison;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            int pointsAmount;
            List<Point> coordinates = new List<Point>();
            int[] coordInput;
            double distance;

            while (testcases-- > 0)
            {
                coordinates.Clear();
                distance = 0.0;

                Console.ReadLine(); //reads the empty line
                pointsAmount = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < pointsAmount; i++)
                {
                    coordInput = Console.ReadLine().Split(' ').Select(c => Int32.Parse(c)).ToArray();
                    Point temp = new Point(coordInput[0], coordInput[1]);
                    coordinates.Add(temp);
                }

                distance = calculateTotalDistance(coordinates);
                Console.WriteLine(string.Format("{0:F2}", Math.Round(distance, 2)));
            }
        }

        public static double calculateTotalDistance(List<Point> coordinates)
        {
            double totalDistance = 0.0;
            coordinates.Sort(new myPointComparer());
            coordinates.Reverse();

            for (int i = 0; i < coordinates.Count - 1; i++)
            {
                totalDistance += calculateDistanceBetweenPoints(coordinates[i], coordinates[i + 1]);
            }

            return totalDistance;
        }

        public static double calculateDistanceBetweenPoints(Point point1, Point point2)
        {
            double distance;

            distance = Math.Sqrt(Math.Pow(point2.posX - point1.posX, 2.0) + Math.Pow(point1.posY - point2.posY, 2.0));

            return distance;
        }
    }
}
