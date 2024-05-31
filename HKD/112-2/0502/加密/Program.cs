using System;
using System.Reflection;

namespace 加密
{
    internal class Program
    {
        static string Encode(string s)
        {
            string[] map = {"", "1", "2", "3", "", "1", "2", "", "", "2", "2", "4", "5", "5", "", "1", "2", "6", "2", "3", "", "1", "", "2", "", "2"};
            string o = "";
            for (int i = 0; i < s.Length; i++) o += map[s[i] - 'A'];
            return o;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("KHAWN"));
            Console.WriteLine(Encode("PFISTER"));
            Console.WriteLine(Encode("BOBBY"));
            Console.ReadKey();
        }
    }
}
