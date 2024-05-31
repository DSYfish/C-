using System;

namespace _11210301最少派車次數
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] time = new int[25];
            for (int i = 0; i < num; i++) 
            {
                int s = int.Parse(str[2 * i]);
                int e = int.Parse(str[2 * i + 1]);
                for (int j = s; j < e; j++)
                {
                    time[j]++;
                }
            }
            int max = time[0];
            foreach (int i in time)
            {
                if (i > max) max = i;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
