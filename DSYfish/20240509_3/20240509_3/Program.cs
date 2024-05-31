using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240509_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] point = {{3, 3}, {1, 5}, {4, 6}, {2, 8}, {9, 9},
        {2, 1}, {7, 2}, {6, 5}, {9, 4}, {5, 9}};
            double d = 10000000;
            for (int i = 0; i < point.GetLength(0); i++)
            {
                for (int j = i+1; j < point.GetLength(0); j++)
                {
                    double dx = point[i,0] - point[j,0];
                    double dy = point[i,1] - point[j,1];
                    double dij = Math.Sqrt(dx * dx + dy * dy);
                    if (dij < d) d = dij;
                }
            }
            Console.WriteLine("距離是："+d);
            Console.ReadLine();
        }
    }
}
