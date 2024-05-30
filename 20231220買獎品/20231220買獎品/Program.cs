using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20231220買獎品
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int t = int.Parse(str[0]);
                int m = int.Parse(str[1]);
                int k = int.Parse(str[2]);
                int ans = 0;
                string[] str2 =Console.ReadLine().Split(' ');
                int[] data = new int[k];
                for (int i2=0;i2<k;i2++)
                {
                    data[i2] = int.Parse(str2[i2]);
                }
                Array.Sort(data);
                for (int j=0;j<m;j++) 
                {
                    ans += data[j];
                }
                if (ans > t)
                {
                    Console.WriteLine("Impossible");
                }
                else 
                {
                    Console.WriteLine(ans);
                }
            }
        Console.ReadLine();
        }
    }
}
