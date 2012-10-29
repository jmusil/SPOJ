using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_PERMUT2
{
    class Program
    {
        static int Main(string[] args)
        {
            while (int.Parse(Console.ReadLine()) != 0)
            {
                bool ambiguous = true;
                string input = Console.ReadLine();
                string[] tokenizedInput;// = new string[input.Length];
                List<int> intInput = new List<int>();
                //int[] intInput = new int[input.Length];
                tokenizedInput = input.Split(' ');
                for (int i = 0; i < tokenizedInput.Length; i++)
                {
                    intInput.Add(Int32.Parse(tokenizedInput[i]));

                }
                for (int i = 0; i < intInput.Count; i++)
                {
                    if (i + 1 != intInput[intInput[i]-1])
	                {
		                ambiguous = false;
                        break;
	                }
                    
                }
                if (ambiguous)
                {
                    Console.WriteLine("ambiguous");
                }
                else
                {
                    Console.WriteLine("not ambiguous");
                }

            }
            return 0;
        }
    }
}
