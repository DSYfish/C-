using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20240307最大公因數_輾轉相除法_
{
    internal class Program
    {
        static int gcb(int n,int m)
        {
            if (n%m == 0)
            {return m;}
            else
            {return gcb(n, n % m);}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("最大公因數");
            Console.Write("輸入一個整數n：");
            int n = int.Parse(Console.ReadLine());
            Console.Write("輸入一個整數m：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(gcb(n,m));
            Console.ReadLine();
        }
    }
}
