using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_HOLES
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            
            while (testcases > 0)
            {
                string input = Console.ReadLine();
                char[] line = new char[input.Length];
                line = input.ToArray<char>();
                int numberOfHoles = 0;
                foreach (char letter in line)
                {
                    numberOfHoles += GetHoles(letter);
                }
                Console.WriteLine(numberOfHoles);
                testcases--;
            }
        }

        static int GetHoles(char c)
        {
            switch (c)
            {
                case 'A':
                case 'D':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                    return 1;
                case 'B':
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
