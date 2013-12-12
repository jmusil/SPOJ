using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_STONES
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            string jewels;
            string jewelsRaw;
            string minedStones;
            int jewelsCount;
            while (testcases-- > 0)
            {
                jewelsCount = 0;
                jewelsRaw = Console.ReadLine();
                minedStones = Console.ReadLine();

                StringBuilder foo = new StringBuilder();
                foreach (var character in jewelsRaw)
                {
                    if (!foo.ToString().Contains(character))
                    {
                        foo.Append(character);
                    }
                }
                jewels = jewelsRaw.ToString();
                foreach (var character in minedStones)
                {
                    if (jewels.Contains(character))
                    {
                        jewelsCount++;
                    }
                }
                Console.WriteLine(jewelsCount);
            }
        }
    }
}
