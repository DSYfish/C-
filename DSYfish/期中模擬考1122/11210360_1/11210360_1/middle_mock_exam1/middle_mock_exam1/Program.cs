using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middle_mock_exam1
{
    class Program
    {
        static int Max(int x, int y)
        {
            //return x>=y ? x : y;
            if (x > y) return (x);
            return (y);
        }
        static int Max(int x, int y, int z)
        {
            if ((x > y) && (y > z)) return (x);
            else if ((y > z) && (y > x)) return (y);
            else return (z);
        }

        static int Max(int[] x)
        {
             int max = x[0];
            foreach(int item  in x)
            {
                if (item > max) max = item;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] data = { 1, 10, 3, 9, 7 };
            Console.WriteLine(Max(3, 8));
            Console.WriteLine(Max(3, 9, 7));
            Console.WriteLine(Max(data));
            Console.ReadKey();
        }
    }
}
