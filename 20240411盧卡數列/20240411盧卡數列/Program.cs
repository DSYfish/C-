using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240411盧卡數列
{
    internal class Program
    {
        static int Lucas(int n)
        {
            if (n == 0) return 2;
            if (n == 1) return 1;
            return Lucas(n - 1)+Lucas(n-2);
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入一個正整數：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Lucas(n));
            Console.ReadLine();
        }
    }
}
