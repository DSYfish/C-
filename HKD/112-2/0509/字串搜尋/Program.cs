using System;

namespace 字串搜尋
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string t = "It's a pencil.";
            string p = "a pen";
            for (int i = 0; i < t.Length - p.Length + 1; i++)
            {
                bool find = true;
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] != t[i + j])
                    {
                        find = false;
                    }
                    if (find)
                    {
                        Console.WriteLine($"在第{i}字元找到文字");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
