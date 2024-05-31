using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240307
{
    internal class Program
    {
        static int f(int n)
        {
            if (n == 0) return 1;
            return n * f(n - 1);

        }

        static int f2(int n, int n2)
        {
            if(n2 == 0) return 0;
            return n +f2(n,n2-1);
        }
        static int f3(int n , int n2)
        {
            if (n2 == 0)return 0;
            return n * f3(n, n2 - 1);
            //return (int)Math.Pow(n,n2);
        }

        static void Main(string[] args)
        {
            Console.Write("第幾題(1~3)：");
            int i = int.Parse(Console.ReadLine());
            int n; int n2;
            switch (i)
            {
                case 1:
                    Console.WriteLine("階層");
                    Console.Write("請輸入一個數：");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(f(n));
                    break;
                case 2:
                    Console.WriteLine("乘法");
                    Console.Write("請輸入兩個數(用空白隔開):");
                    string[] a = Console.ReadLine().Split(' ');
                    n = int.Parse((string)a[0]);
                    n2 = int.Parse((string)a[1]);
                    Console.WriteLine(f2(n,n2));
                    break;
                case 3:
                    Console.WriteLine("次方");
                    Console.Write("請輸入兩個數(用空白隔開):");
                    string[] b = Console.ReadLine().Split(' ');
                    n = int.Parse((string)b[0]);
                    n2 = int.Parse((string)b[1]);
                    Console.WriteLine(f3(n, n2));
                    break;
            }           
             Console.ReadLine();
        }
    }
}
