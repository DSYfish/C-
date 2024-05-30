using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240523_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n)
                        Console.Write("＠");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (i==0 ||i==n-1||j==0||j==n-1)
                        Console.Write('＠');
                    else
                        Console.Write('　');
                }
                Console.WriteLine();
            }
            
           Console.ReadKey();
        }
    }
}
