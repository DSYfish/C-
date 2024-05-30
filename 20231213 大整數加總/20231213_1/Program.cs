using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231213_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int[] first = new int[30];
                int[] second = new int[30];
                int[] sum = new int[30];

                //拆分字串裡面的值
                for(int j = 0; j < num[0].Length;j++) 
                {
                    first[num[0].Length - 1 - j] = int.Parse(num[0][j].ToString());
                }
                for (int j = 0; j < num[1].Length;j++)
                {
                    second[num[1].Length - 1 - j] = int.Parse(num[1][j].ToString());
                }
                
                //加總
                int carry = 0; //carry為進位
                for(int j = 0 ; j < 30;j++) 
                {
                    int tmp = first[j] + second[j] + carry;
                    sum[j] = tmp%10; //暫存tmp除於10的餘數放置sum原位置
                    carry = tmp/10; // 暫存tmp除於10的整數放置carry進位
                }
                int flag = 0;
                for(int j = 29; j >= 0; j--) 
                {
                    if (sum[j] != 0) 
                    {
                        flag = j;
                        break;
                        }
                }
                for(int j = flag;j >= 0; j--) 
                {
                    Console.Write(sum[j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
