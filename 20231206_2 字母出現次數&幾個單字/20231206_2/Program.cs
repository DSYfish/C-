using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231206_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] str = s.Split(' ');
            string alpha = "abcdefghijklmnopqrstuvwxyz"; //先定義字母的字串
            int[] intAlpha = new int[alpha.Length]; // 建立字母長度的List
            Console.WriteLine(str.Length);//輸出1

            for (int i  = 0; i < s.Length; i++) 
            {
                int flag = -1;
                for(int j = 0; j < alpha.Length; j++) //找到資料從第一筆找到最後一筆
                {
                    if (s[i].ToString().ToLower() == alpha[j].ToString())
                    {
                        flag = j; break; //找到就跳出
                    }                    
                }
                if (flag >= 0)
                {
                    intAlpha[flag]++;
                }
            }
            for (int i = 0;i < intAlpha.Length; i++)  
            {
                if (intAlpha[i] > 0)
                {
                    Console.WriteLine(alpha[i]+ ":" + intAlpha[i]);   //alpha的i位置輸出intAlpha的i的值
                }
            }
            Console.ReadKey();
        }
    }
}
