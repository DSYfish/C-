using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240103期末模擬考第一題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一整數：");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
