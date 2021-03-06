﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_DIRECTI
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Int32.Parse(Console.ReadLine());

            while (testcases-- > 0)
            {
                List<KeyValuePair<string, string>> directions = new List<KeyValuePair<string, string>>();
                int lines = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < lines; i++)
                {
                    string line = Console.ReadLine();
                    string[] splitLine = line.Split(' ');
                    StringBuilder street = new StringBuilder();
                    for (int j = 2; j < splitLine.Length; j++)
                    {
                        street.Append(splitLine[j]);
                        if (j != splitLine.Length - 1)
                        {
                            street.Append(" ");
                        }
                    }

                    directions.Add(new KeyValuePair<string, string>(splitLine[0], street.ToString()));
                }

                StringBuilder result = new StringBuilder();
                result.Append("Begin on ");
                result.Append(directions.ElementAt(directions.Count - 1).Value);
                result.Append(Environment.NewLine);

                for (int i = directions.Count - 1; i > 0; i--)
                {
                    switch (directions.ElementAt(i).Key)
                    {
                        case "Left":
                            result.Append("Right");
                            break;
                        case "left": 
                            result.Append("right"); 
                            break;
                        case "Right": 
                            result.Append("Left"); 
                            break;
                        case "right": 
                            result.Append("left"); 
                            break;
                        default: 
                            break;
                    }

                    result.Append(" on ");
                    result.Append(directions.ElementAt(i - 1).Value);
                    if (i > 1)
                    {
                        result.Append(Environment.NewLine);
                    }
                }


                Console.WriteLine(result.ToString());
                if (testcases > 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
