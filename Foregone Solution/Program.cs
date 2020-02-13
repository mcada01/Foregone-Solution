using System;
using System.Collections;
using System.Collections.Generic;

namespace Foregone_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            int testsNumber = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < testsNumber; j++)
            {
                lines.Add(Console.ReadLine()); 
            }

            for (int i = 0; i < lines.Count; i++)
            {
                string num = lines[i];
                if (!num.Contains("4"))
                {
                    Console.WriteLine("N must contain at least a 4");
                }
                else
                {
                    string a = string.Empty;
                    string b = string.Empty;
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (num.Substring(j, 1) == "4")
                        {
                            a = a.Insert(j, "2");
                            b = b.Insert(j, "2");
                        }
                        else
                        {
                            a = a.Insert(j, num.Substring(j, 1));
                            b = b.Insert(j, "0");
                        }
                    }
                    Console.WriteLine("Case #{0}: {1} {2}", (i + 1).ToString(), a, b);
                }
            }
        }
    }
}
