using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240425_5人潮最多的時段
{
    internal class Program
    {
        static int Compare(int x, int y)
        {//數學絕對值比較
            if(Math.Abs(x) > Math.Abs(y)) return 1;
            else if(Math.Abs(x)< Math.Abs(y)) return -1; 
            else return 0;
        }
        static void Main(string[] args)
        {
            int[] times = { 2, -5, 1, -11, 3, -7, 8, -12 };
           Array.Sort(times,Compare);
            int count = 0,maxCount = 0,maxTimes= 0;
            for (int i = 0; i <times.Length; i++)
            {
                if (times[i] > 0)
                { count++; }
                else
                {
                    count--;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxTimes = times[i];
                }
            }

            Console.WriteLine("人潮最多時段"+maxCount+"人");
           // Console.WriteLine("人潮最多時段:"+maxTimes);
            Console.ReadLine();

        }
    }
}
