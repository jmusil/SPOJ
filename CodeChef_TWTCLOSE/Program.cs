/*
 Solution in JS: http://jsfiddle.net/f3z0j/CVRqy/6/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_TWTCLOSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int numberOfTweets = Int32.Parse(firstLine[0]);
            int numberOfClicks = Int32.Parse(firstLine[1]);
            int[] tweets = new int[numberOfTweets];
            int openedTweets = 0;


            string input;
            string[] splitInput;
            int lineToChange;

            for (int i = 0; i < numberOfClicks; i++)
            {
                input = Console.ReadLine();
                if (input.Contains(' '))
                {
                    splitInput = input.Split(' ');
                    lineToChange = Int32.Parse(splitInput[1])-1;
                    if (tweets[lineToChange] == 0)
                    {
                        tweets[lineToChange] = 1;
                        openedTweets++;
                    }
                    else
                    {
                        tweets[lineToChange] = 0;
                        openedTweets--;
                    }
                }
                else
                {
                    for (int j = 0; j < numberOfTweets; j++)
                    {
                        tweets[j] = 0;
                    }
                    openedTweets = 0;
                }
                Console.WriteLine(openedTweets);
            }
        }
    }
}
