using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeChef_TIDRICE
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());
            Dictionary<string, string> votes = new Dictionary<string, string>();
            string[] input;
            int score;
            while (testcases-- > 0)
            {
                score = 0;
                votes.Clear();
                int votesAmount = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < votesAmount; i++)
                {
                    input = Console.ReadLine().Split(' ');
                    if (!votes.Keys.Contains(input[0]))
                    {
                        votes.Add(input[0], input[1]);
                    }
                    else
                    {
                        votes[input[0]] = input[1];
                    }
                    
                }
                foreach (var key in votes.Keys)
                {
                    if (votes[key] == "+")
                    {
                        score++;
                    }
                    else
                    {
                        score--;
                    }
                }
                Console.WriteLine(score);
            }
        }
    }
}
