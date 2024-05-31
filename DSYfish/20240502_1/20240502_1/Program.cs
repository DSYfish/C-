using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240502_對照表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            int[] c = new int[26];
            s=Console.ReadLine().Trim();
            s=s.ToLower();
            for(int i = 0; i < s.Length; i++) 
            {
                if (s[i] >= 'a' && s[i]<= 'z')
                {
                    c[s[i] - 'a']++;
                }
            }
            for(int i = 0;i < c.Length; i++)
            {
                if (c[i]  > 0)
                {
                    Console.WriteLine((char)(i + 'a') + ":" + c[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
