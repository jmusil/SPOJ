using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_ONP
{
    class Program
    {
        static int Main(string[] args)
        {
            int amountOfTestcases = int.Parse(Console.ReadLine());
            while (amountOfTestcases != 0)
            {
                String input = Console.ReadLine();
                char[] charInput = new char[input.Length];
                charInput = input.ToArray();
                StringBuilder output = new StringBuilder();
                Stack<char> stack = new Stack<char>();
                foreach (char character in charInput)
                {
                    if (Char.IsLetter(character))
                    {
                        output.Append(character);
                    }
                    else if (character != ')')
                    {
                        stack.Push(character);
                    } 
                    else
                    {
                        while (stack.First() != '(')
                        {
                            output.Append(stack.First());
                            stack.Pop();    
                        }
                        stack.Pop();
                    }
                }
                Console.WriteLine(output.ToString());
                amountOfTestcases--;
            }
            return 0;
        }
    }
}
