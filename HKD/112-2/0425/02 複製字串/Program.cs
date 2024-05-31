using System;

namespace 複製字串
{
    internal class Program
    {
        static string copytext(string[] stringarr)
        {
            string txt = "";
            foreach (string s in stringarr)txt += s;
            return txt;
        }
        static string revstr(string[] stringarr)
        {
            string tmp = "";
            for (int i = stringarr.Length -1; i >= 0; i--)
            {
                tmp += stringarr[i];
            }
            return tmp;
        }
        static string evenstr(string text)
        {
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if(i%2 == 1)tmp += text[i];
            }
            return tmp;
        }
        static void Main(string[] args)
        {
            string text = "Hello World!";
            string[] textarr = new string[text.Length];
            for (int i = 0; i < textarr.Length; i++) 
            {
                textarr[i] = text.Substring(i, 1);
            }
            Console.WriteLine($"原本字串：{text}");
            Console.WriteLine($"偶數位的字串：{evenstr(text)}");
            Console.WriteLine($"複製後的字串：{copytext(textarr)}");
            Console.WriteLine($"反轉後的字串：{revstr(textarr)}");
            Console.ReadKey();
        }
    }
}
