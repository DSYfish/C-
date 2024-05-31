using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231213ex3Basic19.最少派車數_一維陣列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] count = new int[25];
            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(str[2*i]);
                int e = int.Parse(str[2*i+1]);
                for (int j = s; j < e; j++) 
                {
                    count[j]++;
                }
            }
            int max = count[0];
            foreach (int i in count)
            {
                if (i > max) max = i;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
