using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240425_4直角三角形
{
    internal class Program
    {
        static void printSymbo(int n,char c)
        {
            for (int i = 1; i <= n; i++)
                Console.Write(c);
        }


        static void Main(string[] args)
        {
            //正方形口
            int n = 5;
            for(int i = n; i >= 1; i--)
            {
                printSymbo(i,'@');
                printSymbo((n - i) * 2, ' ');
                printSymbo(i, '@');
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                printSymbo(i, '@');
                printSymbo((n - i) * 2, ' ');
                printSymbo(i, '@');
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = n; i >= 1; i--)
            {
                printSymbo(i, '@');
                printSymbo((n - i), ' ');
                printSymbo(i, '@');
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
