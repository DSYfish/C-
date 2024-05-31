using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middle_mock_exam2
{
    class Program
    {
        static int recursive(int n)
        {
            if (n == 0 || n == 1 || n == 2) return 1;
            else return recursive(n - 2) + recursive(n-3);
        }
        static void Main(string[] args)
        {
            Console.Write("請輸入一個正整數:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(recursive(n));
            Console.ReadKey();
        }
    }
}
