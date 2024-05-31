using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11210301_河內塔
{
    internal class Program
    {
        static int num = 0;
        static void hanoi(int n, char A, char B, char C)
        {
            if(n == 1)
            {

                Console.WriteLine($"{(Program.num++).ToString("0000")} 從{A}移到{C}");
            }
            else
            {
                hanoi(n-1, A, C, B);
                Console.WriteLine($"{(Program.num++).ToString("0000")} 從{A}移到{C}");
                hanoi(n-1, B, A, C);

            }
        }
        static void Main(string[] args)
        {
            Console.Write("輸入一整數：");
            int n = int.Parse(Console.ReadLine());
            hanoi(n, 'A', 'B', 'C');
            Console.ReadKey();
        }
    }
}
