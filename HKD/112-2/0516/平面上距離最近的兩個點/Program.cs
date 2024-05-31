using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 平面上距離最近的兩個點
{
    public class Point
    {
        public double x , y ;
        public Point(double x , double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        static int cmp(Point a,Point b)
        {
            if (a.x < b.x) return -1;
            else if (a.x > b.x) return 1;
            else return 0;
        }
        static double dist(Point a,Point b)
        {
            double dx = a.x - b.x;
            double dy = a.y - b.y;
            return Math.Sqrt(dx*dx + dy*dy);
        }
        static void Main(string[] args)
        {
            Point[] point = new Point[10];
            point[0] = new Point(3, 3);
            point[1] = new Point(1, 5);
            point[2] = new Point(4, 6);
            point[3] = new Point(2, 8);
            point[4] = new Point(9, 9);
            point[5] = new Point(2, 1);
            point[6] = new Point(7, 2);
            point[7] = new Point(6, 5);
            point[8] = new Point(9, 4);
            point[9] = new Point(5, 9);
            Array.Sort(point, cmp);
            double d = 10000000000;
            for (int i = 0; i < point.Length; i++)
            {
                for (int j = i+1; j < point.Length; j++)
                {
                    if (point[j].x - point[i].x > d) break;
                    d = Math.Min(d, dist(point[i], point[j]));
                }
            }
            Console.WriteLine("最短距離："+d);
            Console.ReadKey();
        }
    }
}
