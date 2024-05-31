using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 平面上距離最近的兩個點
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] p ={
                {3, 3}, {1, 5}, {4, 6}, {2, 8}, {9, 9},
                {2, 1}, {7, 2}, {6, 5}, {9, 4}, {5, 9}
            };
            double d = 100000000;

            for (int i = 0; i < p.GetLength(0); i++)
            {
                for (int j = i + 1; j < p.GetLength(0); j++)
                {
                    double dx  = p[i,0] - p[j,0];
                    double dy = p[i,1] - p[j,1];
                    double dij = Math.Sqrt(dx*dx + dy*dy);
                    if (dij < d) d = dij;
                }
            }
            Console.WriteLine($"最短距離：{d}");
            Console.ReadKey();
        }
    }
}
