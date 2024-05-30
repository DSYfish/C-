using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240110第三題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入陣列的大小(空白分隔)：");
            string[] str = Console.ReadLine().Split(' ');
            int m = int.Parse(str[0]);
            int n = int.Parse(str[1]);
            int[,] data = new int[m, n];
            int[] sum = new int[n];
            Console.WriteLine("輸入每一列的資料(空白分隔)：");
            for (int i = 0; i < m; i++)
            { 
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    data[i,j] = int.Parse(str[j]);
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    sum[i] += data[j, i];

            for (int i = 0; i < n; i++)
                Console.Write(sum[i] + " ");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
