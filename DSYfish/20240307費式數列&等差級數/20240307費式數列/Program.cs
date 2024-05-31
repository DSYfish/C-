using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240307費式數列
{
    internal class Program
    {
        static int f(int n)
        {
            if (n <= 2) return 1;
            return f(n-1)+f(n-2);
        }
        static int f2(int m)
        {
            if (m == 1) return 1;
            return f2(m-1) + (2*m-1);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("費式數列");
            Console.Write("請輸入一整數：");
            int n = int.Parse(Console.ReadLine());           
            Console.WriteLine(f(n));

            Console.WriteLine("");
            Console.Write("請輸入一整數：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(f2(m));
            Console.ReadKey();



        }
    }
}
