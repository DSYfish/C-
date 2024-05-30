using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240530_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            n = int.Parse(Console.ReadLine());
            double p = 0;
            for (int i = 0;i<=10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double tmp = p + 1.0 / Math.Pow(10, i) * j;
                    double tmp2= p+1.0/Math.Pow(10, i)*(j+1);
                    if (tmp * tmp <= n && tmp2 * tmp2 > n)
                    {
                        p = tmp;
                        break;
                    }
                }
            }
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
