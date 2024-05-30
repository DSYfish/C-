using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11210360
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] starttime = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(starttime[0]);
            int b = Convert.ToInt32(starttime[1]);
            string[] endtime = Console.ReadLine().Split(' ');
            int c = Convert.ToInt32(endtime[0]);
            int d = Convert.ToInt32(endtime[1]);
            int start = (a * 60) + b;
            int end = (c * 60) + d;
            int x = (end - start)/30;
            if (x <= 4)
            {
                Console.WriteLine(x * 30);
            }
            else if (x > 4 && x <= 8) 
            {
                Console.WriteLine(120+ (x-4) * 40);
            }
            else if (x>8) 
            {
                Console.WriteLine(280+(x-8)*60);
            }
        }
    }
}
