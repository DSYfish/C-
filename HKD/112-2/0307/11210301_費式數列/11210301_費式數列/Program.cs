using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11210301_費式數列
{
    internal class Program
    {
        static int f(int n)
        {
            if (n <= 2) return 1;
            return f(n - 1) + f(n - 2);
        }
        static int f2(int n)
        {
            if (n == 1) return 1;
            return f2(n - 1) + (2*n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("輸入一整數：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(f(n));
            Console.Write("輸入一整數：");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(f2(n));
            Console.ReadKey();
        }

    }
}
