using System;

namespace _11210301_Q3
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
            Console.WriteLine("輸入每一列的資料(空白分隔)：");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = int.Parse(str2[j]);
                }
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                int max = 0;
                for (int j = 0; j < data.GetLength(0); j++)
                {
                    if (data[j,i] > max) max = data[j,i];
                }
                Console.Write(max + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
