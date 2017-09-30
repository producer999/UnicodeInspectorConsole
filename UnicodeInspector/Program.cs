using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeInspector
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            bool escape = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            do
            {
                string s = "";

                do
                {
                    keyInfo = Console.ReadKey();

                    if (!(keyInfo.Key == ConsoleKey.Enter || keyInfo.Key == ConsoleKey.Escape))
                    {
                        s += keyInfo.KeyChar;
                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        escape = true;
                    }
                }
                while (!escape && keyInfo.Key != ConsoleKey.Enter);

                if (!escape && !String.IsNullOrEmpty(s))
                {
                    Console.WriteLine("");
                    Debug.WriteLine("");

                    string input = "";
                    string hexCodes = "";

                    foreach (char c in s)
                    {
                        input += c;

                        int charint = (int)c;
                        hexCodes += "\\u" + charint.ToString("X4");
                    }

                    Console.WriteLine(input + " " + hexCodes);
                    Debug.WriteLine(input + " " + hexCodes);
                }
            }
            while (!escape);
        }
    }
}

