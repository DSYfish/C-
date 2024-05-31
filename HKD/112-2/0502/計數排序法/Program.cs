using System;

namespace 計數排序法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 3, 6, 9, 9, 1 };
            int[] c = new int[10];
            for (int i = 0; i < n.Length; i++)
            {
                c[n[i]]++;
            }
            int index = 0;
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c[i]; j++)
                {
                    n[index++] = i;
                }
            }
            foreach (int data in n)
            {
                Console.Write($"{data} ");
            }
            Console.ReadKey();
            
        }
    }
}
