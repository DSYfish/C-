using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSA_遞迴程式練習
{
    internal class Program
    {
        static int F(int n)
        {
            if(n == 0 || n == 1) return n + 1;
            else return(F(n-1) + F(n/2));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(F(n));
            Console.ReadKey();
        }
    }
}
