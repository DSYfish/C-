using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240307河內塔
{
    internal class Program
    {
        static void hanoi(int n, char A,char B,char C)
        {
            if (n==1)
            {
                Console.WriteLine($"將第1個圓盤從{A}移到{C}");
            }
            else
            {
                hanoi(n - 1, A, C, B);
                Console.WriteLine($"將第{n}個圓盤從{A}移到{C}");
                hanoi(n - 1, B, A,C);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("河內塔");
            Console.Write("輸入一個整數：");
            int n = int.Parse(Console.ReadLine());
            hanoi(n,'A','B','C');
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
