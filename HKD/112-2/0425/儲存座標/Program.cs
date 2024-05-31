using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 儲存座標
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] p=
            {
                { 0, 1}, { 1, 2}, { 3, 0}, { 2, 2}, { 3, 1}
            };
            int[] x = new int[p.GetLength(0)];
            int[] y = new int[p.GetLength(0)];
            for (int i = 0; i < p.GetLength(0); i++)
            {
                x[i] = p[i,0];
                y[i] = p[i, 1];
            }
            Console.ReadKey();
        }
    }
}
