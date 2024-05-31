using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240509_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            n = int.Parse(Console.ReadLine());
            for (int i = 1;i<=n;i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            char[,] array = new char[n,n];
            for (int i = 0; i< n; i++)
            {
                for(int j = 0;j< n; j++)
                {
                    array[i, j] = ' ';
                }
            }
            for(int i = 0;i< n; i++) array[i,0] = '@';
            for (int i = 0; i < n; i++) array[i, n - 1] = '@';
            for (int i = 0; i < n; i++) array[0, i] = '@';
            for (int i = 0; i < n; i++) array[n - 1, i] = '@';

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
