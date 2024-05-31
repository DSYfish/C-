using System;

namespace 人潮最多的時段
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Time = new int[13];
            int[,] Guest = new int[4, 2]
            {{2,-5},{1,-11},{3,-7 },{8,-12}};
            for (int i = 0; i < Time.Length; i++) Time[i] = 0;
            for (int i = 0; i < Guest.GetLength(0); i++)
            {
                for (int j = Guest[i, 0]; j <= Math.Abs(Guest[i, 1]); j++)
                {
                    Time[j]++;
                }
            }
            int max = 0;
            foreach (int i in Time)
            {
                if (i > max) max = i;
            }
            Console.Write("高峰時段有：");
            for (int i = 0; i < Time.Length; i++)
            {
                if (Time[i] == max) Console.Write($"{i} ");
            }
            Console.WriteLine($"\n共有{max}人");
                Console.ReadKey();
        }
    }
}
