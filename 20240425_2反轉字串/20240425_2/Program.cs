using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240425_2
{
    internal class Program
    {
        static string copytext(string text)
        {
            string copy = "";
            for (int i = 0; i<= text.Length-1; i++)
            {copy += text[i];}
            return copy;
        }
        static string strReverse(string text) 
        {
            string s = "";
            for (int i = text.Length-1; i >= 0; i--)
            {s += text[i];}    
            return s;
        }
        static string eventext(string text)
        {
            string s = "";
            for (int i = 0; i <=text.Length-1; i+= 2)
            {s += text[i];}
            return s;
        }
        static void Main(string[] args)
        {
            string text = "abcde";
            Console.WriteLine("原字串:" + text);
            Console.WriteLine("複製後的字串:"+copytext(text));
            Console.WriteLine("反轉後的字串:"+strReverse(text));
            Console.WriteLine("字串偶數位:"+eventext(text));
            Console.ReadLine();
        }
    }
}
