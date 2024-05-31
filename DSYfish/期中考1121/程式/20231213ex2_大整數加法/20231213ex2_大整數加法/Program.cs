using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231213ex2_大整數加法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int[] first = new int[30];
                int[] second = new int[30];
                int[] sum = new int[30];

                for (int j = 0; j < str[0].Length; j++)
                {
                    first[str[0].Length - 1 - j] = int.Parse(str[0][j].ToString());
                }
                for (int j = 0; j < str[1].Length; j++)
                {
                    second[str[1].Length - 1 - j] = int.Parse(str[1][j].ToString());
                }
                /*
                foreach (int item in first)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                foreach (int item in second)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                */

                int carry = 0;
                for (int j = 0; j < 30; j++)
                {
                    int tmp = first[j] + second[j] + carry;
                    sum[j] =  tmp % 10;
                    carry = tmp / 10;
                }
                int flag = 0;
                for (int j = 29; j >= 0; j--)
                {
                    if (sum[j] != 0)
                    {
                        flag = j;
                        break;
                    }
                }
                for(int j = flag;j >= 0 ; j--)
                {
                    Console.Write(sum[j]);
                }
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
