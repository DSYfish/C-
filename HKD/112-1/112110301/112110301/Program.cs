using System;

namespace _112110301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();      // 讀取資料
                int t = int.Parse(str[0]);                      // 預算
                int m = int.Parse(str[1]);                      // 員工(所需禮物)
                int k = int.Parse(str[2]);                      // 可選購物品
                int[] gift = new int[k];                        // 把物品價錢
                string[] str2 = Console.ReadLine().Split();     // 讀取資料
                for (int j = 0; j < k; j++)
                {
                    gift[j] = int.Parse(str2[j]);               //把 str2 裡的價錢轉換成 int (gift)
                }
                Array.Sort(gift);                               //排序價格
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += gift[j];                             //加總可選購物品的總價
                }
                Console.WriteLine((sum <= t) ? sum.ToString() : "Impossible");
            }
                Console.ReadLine();
        }
    }
}
