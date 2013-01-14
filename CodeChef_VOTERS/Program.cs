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
            string[] inputString = Console.ReadLine().Split(' ');
            int[] amountOfInputData = new int[3];
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string value;
            List<int> validVoters = new List<int>();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < 3; i++)
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
            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                if (pair.Value > 1)
                {
                    validVoters.Add(Int32.Parse(pair.Key));
                }
            }
            validVoters.Sort();
            output.Append(validVoters.Count);
            output.Append(Environment.NewLine);
            foreach (int item in validVoters)
            {
                output.Append(item);
                output.Append(Environment.NewLine);
            }
            Console.WriteLine(output.ToString());
        }
    }
}