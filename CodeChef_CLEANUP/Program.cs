using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef_CLEANUP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations
            int testcases;
            string firstInputLine;
            string secondInputLine;
            int jobsAmount;
            int finishedJobsAmount;
            int[] finishedJobs;
            List<int> chefsJobs = new List<int>();
            List<int> assistantsJobs = new List<int>();
            bool assignToChef;
            StringBuilder chefsResults = new StringBuilder();
            StringBuilder assistantsResults = new StringBuilder();
            #endregion

            testcases = Int32.Parse(Console.ReadLine());
            while (testcases-- > 0)
            {
                firstInputLine = Console.ReadLine();
                secondInputLine = Console.ReadLine();
                jobsAmount = firstInputLine.Split(' ').Select(n => Int32.Parse(n)).First();
                finishedJobsAmount = firstInputLine.Split(' ').Select(n => Int32.Parse(n)).Last();
                finishedJobs = secondInputLine.Split(' ').Select(n => Int32.Parse(n)).ToArray();
                chefsJobs.Clear();
                assistantsJobs.Clear();
                chefsResults.Clear();
                assistantsResults.Clear();

                assignToChef = true;

                for (int i = 1; i <= jobsAmount; i++)
                {
                    if (!finishedJobs.Contains(i))
                    {
                        if (assignToChef)
                        {
                            chefsJobs.Add(i);
                            assignToChef = false;
                        }
                        else
                        {
                            assistantsJobs.Add(i);
                            assignToChef = true;
                        }
                    }
                }

                foreach (int item in chefsJobs)
                {
                    chefsResults.Append(item.ToString());
                    if (item != chefsJobs.Last())
                    {
                        chefsResults.Append(" ");    
                    }
                }
                foreach (int item in assistantsJobs)
                {
                    assistantsResults.Append(item.ToString());
                    if (item != assistantsJobs.Last())
                    {
                        assistantsResults.Append(" ");    
                    }
                }

                Console.WriteLine(chefsResults);
                Console.WriteLine(assistantsResults);
            }
        }
    }
}
