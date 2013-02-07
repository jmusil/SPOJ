using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CODECHEF_VOTERS
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RESULT_SETS_AMOUNT = 3;
            string[] inputString = Console.ReadLine().Split(' ');
            int[] amountOfInputData = new int[RESULT_SETS_AMOUNT];
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string value;
            List<int> validVotes = new List<int>();
            
            for (int i = 0; i < RESULT_SETS_AMOUNT; i++)
            {
                amountOfInputData[i] = Int32.Parse(inputString[i]);
                while (amountOfInputData[i]-- > 0)
                {
                    value = Console.ReadLine();
                    if (!dictionary.ContainsKey(value))
                    {
                        dictionary.Add(value, 1);
                    }
                    else if (dictionary.ContainsKey(value))
                    {
                        dictionary[value]++;
                    }
                }
            }
            
            validVotes = getValidVotes(dictionary);
            validVotes.Sort();
            outputResults(validVotes);
            
        }

        public static List<int> getValidVotes(Dictionary<string, int> allVotes)
        {
            List<int> validVotes = new List<int>();
            foreach (KeyValuePair<string, int> pair in allVotes)
            {
                if (pair.Value > 1)
                {
                    validVotes.Add(Int32.Parse(pair.Key));
                }
            }
           
            return validVotes;
        }

        public static void outputResults(List<int> results)
        {
            StringBuilder output = new StringBuilder();
            output.Append(results.Count);
            output.Append(Environment.NewLine);
            foreach (int item in results)
            {
                output.Append(item);
                output.Append(Environment.NewLine);
            }
            Console.WriteLine(output.ToString());
        }
    }
}