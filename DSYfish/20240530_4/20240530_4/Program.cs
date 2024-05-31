using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240530_4
{
    internal class Program
    {
        static int gcd1(int a,int b)
        {
            while(b!= 0)
            {
            int t = a % b;
            a = b;
            b = t;
            }
            return a;
        }
        static int gcd2(int a,int b)
        {
            if(b==0)
                return a;
            return gcd2(b, a % b);

        }
        static void Main(string[] args)
        {
            int m = 16;
            int n = 12;
            string[] a = Console.ReadLine().Split(' ');
            m = int.Parse(a[0]); n = int.Parse(a[1]);
            Console.WriteLine(gcd1(m, n));
            Console.WriteLine(gcd2(m, n));
            Console.ReadLine();
        }
    }
}
