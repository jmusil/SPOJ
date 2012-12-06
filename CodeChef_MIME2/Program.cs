using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef_MIME2
{
    class Program
    {
        static int Main(string[] args)
        {
            String[] amounts = Console.ReadLine().Split(' ');
            Dictionary<String, String> mimeTypes = new Dictionary<string, string>();
            String[] mimeInput;
            String[] fileInput;
            String fileInputRaw;
            
            for (int i = 0; i < Int32.Parse(amounts[0]); i++)
            {
                mimeInput = Console.ReadLine().Split(' ');
                mimeTypes.Add(mimeInput[0],mimeInput[1]);
            }

            for (int i = 0; i < Int32.Parse(amounts[1]); i++)
            {
                fileInputRaw = Console.ReadLine();
                fileInput = fileInputRaw.Split('.');
                if (!fileInputRaw.Contains('.') || fileInputRaw.EndsWith("."))
                {
                    Console.WriteLine("unknown");
                }
                else if (!mimeTypes.ContainsKey(fileInput[fileInput.Length-1]))
                {
                    Console.WriteLine("unknown");
                }
                else
                {
                    Console.WriteLine(mimeTypes[fileInput[fileInput.Length - 1]]);
                }

            }
            return 0;
        }
    }
}
