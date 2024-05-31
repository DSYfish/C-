using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middle_mock_exam1
{
    class Program
    {
        static int Max(int x, int y)
        {
            return (x>y) ? x : y;
        }
        static int Max(int x, int y, int z)
        {
            int max = (x>y) ? x : y;
            return (max> z) ? max : z;
        }

        static int Max(int[] x)
        {
            int max = 0;
            foreach (int item in x)
            {
                max = (item > max) ? item : max;
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
