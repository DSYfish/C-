using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240502_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mapTable = "`1234567890-=QWERTYUIOP[]\\ASDFGHJKL;'ZXCVBNM,./";
            string s = "O S, GOMR YPFSU/";
            string output = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') output += ' ';
                else
                {
                    output += mapTable[mapTable.IndexOf(s[i]) - 1];
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
