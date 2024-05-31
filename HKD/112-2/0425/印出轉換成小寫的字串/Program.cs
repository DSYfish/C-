using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace 印出轉換成小寫的字串
{
    internal class Program
    {
        static string print_lowercase(string str)
        {
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    str1 += (char)(str[i] - 'A' + 'a');
                }
                else
                {
                    str1 += str[i];
                }
            }
            return str1;
        }
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine($"原本字串：{str}");
            Console.WriteLine($"轉成小寫：{print_lowercase(str)}");
            Console.ReadKey();
        }
    }
}
