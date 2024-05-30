using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231220嘴少派車數
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            int[] count = new int[25];
            for (int i = 0;i<n ;i++)
            {
                int s = int.Parse(num[2*i]);
                int e = int.Parse(num[2*i+1]);
                for(int j = s; j <= e; j++)
                {
                    count[j]++;
                }
            }
            int max = count[0];
            foreach(int i in count)
            {
                if (i > max) max = i;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
