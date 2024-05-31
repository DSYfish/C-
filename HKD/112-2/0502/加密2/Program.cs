using System;

namespace 加密2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mapTable = "`1234567890-=QWERTYUIOP[]\\ASDFGHJKL;'ZXCVBNM,./";
            string s = "O S, GOMR YPFSU";
            string o = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    o += ' ';
                    continue;
                }
                o += mapTable[mapTable.IndexOf(s[i]) - 1];
            }
            Console.WriteLine(o);
            Console.ReadKey();
        }
    }
}
