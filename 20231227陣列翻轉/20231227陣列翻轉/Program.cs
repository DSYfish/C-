using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231227陣列翻轉
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] d = Console.ReadLine().Split(' ');
                int m = int.Parse(d[0]);
                int n = int.Parse(d[1]);
                int[,] data = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    string[] d2 = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        data[i, j] = int.Parse(d2[j]);
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(data[j, i] +" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

            }
        }
    }
}
