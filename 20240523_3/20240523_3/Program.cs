using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240523_3
{
    internal class Program
    {
        static int count3N_1(int n)
        {
            int count = 0;
            while (n!= 1)
            {
                if(n%2 == 1)
                {
                    n = 3 * n + 1;
                }
                else
                {
                    n = n / 2;
                }
                count++;
            }
            count++;
            return count;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                int m = int.Parse(s[0]);
                int n = int.Parse(s[1]);
                int maxCount = 0;
                for(int i = m;i<= n; i++)
                {
                    maxCount= Math.Max(maxCount,count3N_1(i));
                }
                Console.WriteLine(m+" "+n+" "+maxCount);
                Console.ReadLine();
            }
        }
    }
}
