using System;

namespace 尋找總和為_10_的區間
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 6, 1, 7, 2, 4, 6, 3, 5, 1, 4, 1, 1, 1, 9, 1 ,9};
            int sum = 0;
            int i = 0, j = -1;
            while (j < a.Length)
            {
                if (sum < 10 && j + 1 != a.Length) sum += a[++j];
                else if (sum > 10) sum -= a[i++];
                else if (sum == 10 && j + 1 != a.Length) sum += a[++j];
                else break;

                if (sum == 10) Console.WriteLine($"[{i}~{j}] = 10");

                //if (sum == 10) Console.WriteLine($"[{i.ToString().PadLeft(2,'0')}~{j.ToString().PadLeft(2, '0')}] = 10");
            }
            Console.ReadKey();
        }
    }
}
